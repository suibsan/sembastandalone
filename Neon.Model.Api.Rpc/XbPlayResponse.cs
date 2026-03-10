
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPlayResponse {
    [ProtoMember(3)]
    public XbGameInfo currentAtBatGameInfo { get; set; }

    [ProtoMember(4)]
    public XbGameInfo nextAtBatGameInfo { get; set; }

    [ProtoMember(5)]
    public XbGameResult result { get; set; }

    [ProtoMember(1)]
    public Rewards[] rewards { get; set; }

    [ProtoMember(8)]
    public Resource[] ignoredRewards { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

    [ProtoMember(6)]
    public XbPvpRankState rankMatchRankState { get; set; }

    [ProtoMember(7)]
    public XbInningHalfScoreBoard[] scoreBoards { get; set; }

}