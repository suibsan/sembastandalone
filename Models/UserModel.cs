
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class UserModel {

public UserCrossDateResponse? User_CrossDate() {
    // no request
    return UserCrossDateResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/cross_date", "")
    );
}


public UserDeleteResponse? User_Delete() {
    // no request
    return UserDeleteResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/delete", "")
    );
}


public ChangedResourcesResponse? User_LinkApple(UserLinkAppleRequest req) {
    Console.WriteLine($"User_LinkApple: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/link_apple", req.ToString())
    );
}


public ChangedResourcesResponse? User_LinkGoogle(UserLinkGoogleRequest req) {
    Console.WriteLine($"User_LinkGoogle: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/link_google", req.ToString())
    );
}


public UserLinksListResponse? User_LinksList() {
    // no request
    return UserLinksListResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/links_list", "")
    );
}


public UserLogInResponse? User_LogIn() {
    // no request
    return UserLogInResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/log_in", "")
    );
}


public ChangedResourcesResponse? User_Notification() {
    // no request
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/notification", "")
    );
}


public void User_UnlinkApple() {
    // no request
    sembaWrapper.Call("/user/unlink_apple", "");
}


public void User_UnlinkGoogle() {
    // no request
    sembaWrapper.Call("/user/unlink_google", "");
}


public void User_UnlinkSteam() {
    // no request
    sembaWrapper.Call("/user/unlink_steam", "");
}


public ChangedResourcesResponse? User_UpdateBirthdate(UserUpdateBirthdateRequest req) {
    Console.WriteLine($"User_UpdateBirthdate: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/user/update_birthdate", req.ToString())
    );
}


public void User_UpdateLanguage(UserUpdateLanguageRequest req) {
    Console.WriteLine($"User_UpdateLanguage: {req}");
    sembaWrapper.Call("/user/update_language", req.ToString());
}


private ISembaWrapper sembaWrapper;

public UserModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
