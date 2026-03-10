
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaExecuteResponse {
    [ProtoMember(4)]
    public required GachaCard[] drawnCards { get; set; }

    [ProtoMember(1)]
    public required Reward[] drawnRewards { get; set; }

    [ProtoMember(2)]
    public required Resources changedResources { get; set; }

    [ProtoMember(3)]
    public required Gacha gacha { get; set; }

    [ProtoMember(5)]
    public required Rewards[] rewards { get; set; }

}