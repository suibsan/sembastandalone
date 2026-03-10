
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignUpGoogleResponse {
    [ProtoMember(1)]
    public required long userId { get; set; }

    [ProtoMember(3)]
    public required string userName { get; set; }

    [ProtoMember(2)]
    public required int language { get; set; }

    [ProtoMember(4)]
    public required bool isDeleted { get; set; }

}