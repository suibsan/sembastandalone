
namespace sembastandalone.Models;

using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Primitives;
using System.Text.Json.Nodes;

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

public static JsonNode? requiresAssetsUpdates(HttpRequest req) {
    StringValues platform;
    StringValues masterdataVersion;
    StringValues assetVersion;
    var hasPlatform = req.Headers.TryGetValue("X-platform", out platform);
    var hasAssetVersion = req.Headers.TryGetValue("X-asset-version", out assetVersion);
    var hasMasterdataVersion = req.Headers.TryGetValue("X-master-data-version", out masterdataVersion);

    if (
        hasPlatform && platform[0] == "android"
        && hasAssetVersion && assetVersion[0] == "dummy"
        && hasMasterdataVersion && masterdataVersion[0] == "1754991108_eZMAZkXEu2j4eKRs"
    ) {
        return JsonNode.Parse(
            "{\"asset_version\": \"1751522506_6r3dz52c5q_2zJrU\", \"code\": \"requires_assets_updates\"}"
        ); 
    }

    return null;
}   


}
