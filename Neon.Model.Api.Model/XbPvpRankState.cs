
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpRankState {
    [ProtoMember(1)]
    public required int seasonId { get; set; }

    [ProtoMember(2)]
    public required int rankPoint { get; set; }

    [ProtoMember(3)]
    public required int rewardPoint { get; set; }

    [ProtoMember(5)]
    public required int? prevRankPoint { get; set; }

    [ProtoMember(6)]
    public required int? prevRewardPoint { get; set; }

    [ProtoMember(8)]
    public required int? maxRankPoint { get; set; }

}