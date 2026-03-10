
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserLinkGoogleRequest {
    [ProtoMember(1)]
    public required string idToken { get; set; }

    [ProtoMember(2)]
    public required string code { get; set; }

    [ProtoMember(3)]
    public required string codeVerifier { get; set; }

}