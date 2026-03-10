
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignUpPasscodeResponse {
    [ProtoMember(2)]
    public required string userName { get; set; }

    [ProtoMember(1)]
    public required int language { get; set; }

    [ProtoMember(3)]
    public required bool isDeleted { get; set; }

}