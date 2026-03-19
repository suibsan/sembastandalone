import re


def get_route(class_, name):
    return f"/{pascal_case_to_snake_case(class_)}/{pascal_case_to_snake_case(name)}"


def pascal_case_to_snake_case(name):
    return name[:1].lower() + re.sub(
        r"[A-Z]", lambda x: "_" + x.group(0).lower(), name[1:]
    )


def gen_controller(route, class_, method_name, req_type, res_type):
    if req_type != "None":
        if res_type != "None":
            return_val = "async Task<IActionResult>"
        else:
            return_val = "async Task"

        req_assignment = f"var req = await RequestSerializer.Deserialize<{req_type}>(Request);"
        req_arg = "req"
    else:
        if res_type != "None":
            return_val = "IActionResult"
        else:
            return_val = "void"

        req_assignment = "// no request"
        req_arg = ""

    if res_type != "None":
        res_assignment = "var res = "
        serialize_res = """if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
"""
    else:
        res_assignment = ""
        serialize_res = """// no response
"""

    return f"""
[Route("{route}")]
public {return_val} {method_name}() {{
    {req_assignment}

    {res_assignment}model.{method_name}({req_arg});

    {serialize_res}}}
"""


def gen_model(route, class_, method_name, req_type, res_type):
    if req_type != "None":
        req_log = f"""Console.WriteLine($"{method_name}: {{req}}");"""
        req_param = f"{req_type} req"
        req_tostring = "req.ToString()"
    else:
        req_log = "// no request"
        req_param = ""
        req_tostring = '""'

    semba_wrapper_call = f"""sembaWrapper.Call("{route}", {req_tostring})"""

    if res_type != "None":
        return_type = f"{res_type}?"
        return_parsejson = f"""return {res_type}.Parser.ParseJson(
        {semba_wrapper_call}
    )"""
    else:
        return_type = "void"
        return_parsejson = semba_wrapper_call

    return f"""
public {return_type} {method_name}({req_param}) {{
    {req_log}
    {return_parsejson};
}}
"""


def gen_controller_and_model(method_name, req_type, res_type):
    class_, name = method_name.split("_")

    route = get_route(class_, name)
    
    controller = gen_controller(route, class_, method_name, req_type, res_type)
    
    model = gen_model(route, class_, method_name, req_type, res_type)
    
    return route, controller, model


def gen_model_constructor(class_):
    return f"""
private ISembaWrapper sembaWrapper;

public {class_}Model(ISembaWrapper wrapper) {{
    sembaWrapper = wrapper;
}}
"""


def test_signature_with_req_and_res():
    route, controller, model = gen_controller_and_model(
        "Adventure_AccessWarpPoint",
        "AdventureAccessWarpPointRequest",
        "AdventureAccessWarpPointResponse"
    )

    assert route == "/adventure/access_warp_point"

    assert controller == """
[Route("/adventure/access_warp_point")]
public async Task<IActionResult> Adventure_AccessWarpPoint() {
    var req = await RequestSerializer.Deserialize<AdventureAccessWarpPointRequest>(Request);

    var res = AdventureModel.Adventure_AccessWarpPoint(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}
"""

    assert model == """
public AdventureAccessWarpPointResponse? Adventure_AccessWarpPoint(AdventureAccessWarpPointRequest req) {
    Console.WriteLine($"Adventure_AccessWarpPoint: {req}");
    return AdventureAccessWarpPointResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/access_warp_point", req.ToString())
    );
}
"""


def test_signature_without_req():
    route, controller, model = gen_controller_and_model(
        "Auth_Nonce",
        "None",
        "AuthNonceResponse"
    )

    assert route == "/auth/nonce"

    assert controller == """
[Route("/auth/nonce")]
public IActionResult Auth_Nonce() {
    // no request

    var res = AuthModel.Auth_Nonce();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}
"""

    assert model == """
public AuthNonceResponse? Auth_Nonce() {
    // no request
    return AuthNonceResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/nonce", "")
    );
}
"""


def test_signature_without_res():
    route, controller, model = gen_controller_and_model(
        "User_UpdateLanguage",
        "UserUpdateLanguageRequest",
        "None"
    )

    assert route == "/user/update_language"

    assert controller == """
[Route("/user/update_language")]
public async Task User_UpdateLanguage() {
    var req = await RequestSerializer.Deserialize<UserUpdateLanguageRequest>(Request);

    UserModel.User_UpdateLanguage(req);

    // no response
}
"""

    assert model == """
public void User_UpdateLanguage(UserUpdateLanguageRequest req) {
    Console.WriteLine($"User_UpdateLanguage: {req}");
    sembaWrapper.Call("/user/update_language", req.ToString());
}
"""


def test_signature_without_both():
    route, controller, model = gen_controller_and_model(
        "Xb_ForceRetire",
        "None",
        "None"
    )

    assert route == "/xb/force_retire"

    assert controller == """
[Route("/xb/force_retire")]
public void Xb_ForceRetire() {
    // no request

    XbModel.Xb_ForceRetire();

    // no response
}
"""

    assert model == """
public void Xb_ForceRetire() {
    // no request
    sembaWrapper.Call("/xb/force_retire", "");
}
"""


def test_gen_model_constructor():
    assert gen_model_constructor("Auth") == """
private ISembaWrapper sembaWrapper;

public AuthModel(SembaWrapper wrapper) {
    sembaWrapper = wrapper;
}
"""


def test_generator():
    test_signature_with_req_and_res()
    test_signature_without_req()
    test_signature_without_res()
    test_signature_without_both()
    test_gen_model_constructor()

    print("OK")


if __name__ == "__main__":
    test_generator()