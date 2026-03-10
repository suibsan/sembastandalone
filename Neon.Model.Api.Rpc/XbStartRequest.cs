
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbStartRequest {
    [ProtoMember(1)]
    public required int xbId { get; set; }

    [ProtoMember(2)]
    public required XbMemberRequest[] playerMembers { get; set; }

    [ProtoMember(4)]
    public required long? enemyUserId { get; set; }

    [ProtoMember(5)]
    public required int? enemyCpuUserId { get; set; }

    [ProtoMember(3)]
    public required int? actionSequenceId { get; set; }

}