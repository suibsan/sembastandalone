
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbStartRequest {
    [ProtoMember(1)]
    public int xbId { get; set; }

    [ProtoMember(2)]
    public XbMemberRequest[] playerMembers { get; set; }

    [ProtoMember(4)]
    public long? enemyUserId { get; set; }

    [ProtoMember(5)]
    public int? enemyCpuUserId { get; set; }

    [ProtoMember(3)]
    public int? actionSequenceId { get; set; }

}