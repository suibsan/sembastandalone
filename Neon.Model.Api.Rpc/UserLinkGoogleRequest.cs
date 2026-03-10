
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserLinkGoogleRequest {
    [ProtoMember(1)]
    public string idToken { get; set; }

    [ProtoMember(2)]
    public string code { get; set; }

    [ProtoMember(3)]
    public string codeVerifier { get; set; }

}