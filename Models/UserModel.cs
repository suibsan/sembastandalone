
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class UserModel {

public static UserCrossDateResponse? User_CrossDate() {
    // no request
    return UserCrossDateResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/cross_date", "")
    );
}


public static UserDeleteResponse? User_Delete() {
    // no request
    return UserDeleteResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/delete", "")
    );
}


public static ChangedResourcesResponse? User_LinkApple(UserLinkAppleRequest req) {
    Console.WriteLine($"User_LinkApple: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/link_apple", req.ToString())
    );
}


public static ChangedResourcesResponse? User_LinkGoogle(UserLinkGoogleRequest req) {
    Console.WriteLine($"User_LinkGoogle: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/link_google", req.ToString())
    );
}


public static UserLinksListResponse? User_LinksList() {
    // no request
    return UserLinksListResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/links_list", "")
    );
}


public static UserLogInResponse? User_LogIn() {
    // no request
    return UserLogInResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/log_in", "")
    );
}


public static ChangedResourcesResponse? User_Notification() {
    // no request
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/notification", "")
    );
}


public static void User_UnlinkApple() {
    // no request
    SembaWrapper.Call("/user/unlink_apple", "");
}


public static void User_UnlinkGoogle() {
    // no request
    SembaWrapper.Call("/user/unlink_google", "");
}


public static void User_UnlinkSteam() {
    // no request
    SembaWrapper.Call("/user/unlink_steam", "");
}


public static ChangedResourcesResponse? User_UpdateBirthdate(UserUpdateBirthdateRequest req) {
    Console.WriteLine($"User_UpdateBirthdate: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/user/update_birthdate", req.ToString())
    );
}


public static void User_UpdateLanguage(UserUpdateLanguageRequest req) {
    Console.WriteLine($"User_UpdateLanguage: {req}");
    SembaWrapper.Call("/user/update_language", req.ToString());
}

}
