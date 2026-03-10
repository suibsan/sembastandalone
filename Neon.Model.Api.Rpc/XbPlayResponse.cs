
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPlayResponse {
    [ProtoMember(3)]
    public required XbGameInfo currentAtBatGameInfo { get; set; }

    [ProtoMember(4)]
    public required XbGameInfo nextAtBatGameInfo { get; set; }

    [ProtoMember(5)]
    public required XbGameResult result { get; set; }

    [ProtoMember(1)]
    public required Rewards[] rewards { get; set; }

    [ProtoMember(8)]
    public required Resource[] ignoredRewards { get; set; }

    [ProtoMember(2)]
    public required Resources changedResources { get; set; }

    [ProtoMember(6)]
    public required XbPvpRankState rankMatchRankState { get; set; }

    [ProtoMember(7)]
    public required XbInningHalfScoreBoard[] scoreBoards { get; set; }

}