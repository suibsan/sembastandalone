
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignUpGoogleRequest {
    [ProtoMember(1)]
    public required string deviceSecret { get; set; }

    [ProtoMember(2)]
    public required string deviceUniqueId { get; set; }

    [ProtoMember(3)]
    public required string deviceModel { get; set; }

    [ProtoMember(4)]
    public required string idToken { get; set; }

    [ProtoMember(6)]
    public required string code { get; set; }

    [ProtoMember(7)]
    public required string codeVerifier { get; set; }

    [ProtoMember(5)]
    public required bool execute { get; set; }

}