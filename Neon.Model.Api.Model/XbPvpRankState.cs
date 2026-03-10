
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpRankState {
    [ProtoMember(1)]
    public int seasonId { get; set; }

    [ProtoMember(2)]
    public int rankPoint { get; set; }

    [ProtoMember(3)]
    public int rewardPoint { get; set; }

    [ProtoMember(5)]
    public int? prevRankPoint { get; set; }

    [ProtoMember(6)]
    public int? prevRewardPoint { get; set; }

    [ProtoMember(8)]
    public int? maxRankPoint { get; set; }

}