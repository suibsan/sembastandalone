
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignInResponse {
    [ProtoMember(1)]
    public required string sessionToken { get; set; }

    [ProtoMember(2)]
    public required bool deviceChanged { get; set; }

    [ProtoMember(4)]
    public required int language { get; set; }

}