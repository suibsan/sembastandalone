
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ProfileModel {

public static ChangedResourcesResponse? Profile_UpdateBadges(ProfileUpdateBadgesRequest req) {
    Console.WriteLine($"Profile_UpdateBadges: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/profile/update_badges", req.ToString())
    );
}


public static ChangedResourcesResponse? Profile_UpdateBanner(ProfileUpdateBannerRequest req) {
    Console.WriteLine($"Profile_UpdateBanner: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/profile/update_banner", req.ToString())
    );
}


public static ChangedResourcesResponse? Profile_UpdateCharacterLikabilityScale(ProfileUpdateCharacterLikabilityScaleRequest req) {
    Console.WriteLine($"Profile_UpdateCharacterLikabilityScale: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/profile/update_character_likability_scale", req.ToString())
    );
}


public static ChangedResourcesResponse? Profile_UpdateName(ProfileUpdateNameRequest req) {
    Console.WriteLine($"Profile_UpdateName: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/profile/update_name", req.ToString())
    );
}

}
