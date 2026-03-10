
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBattedBallInfo {
    [ProtoMember(1)]
    public required int? direction { get; set; }

    [ProtoMember(2)]
    public required bool isInfield { get; set; }

    [ProtoMember(4)]
    public required XbRunningInfo[] runningInfos { get; set; }

    [ProtoMember(5)]
    public required float time { get; set; }

    [ProtoMember(6)]
    public required XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(7)]
    public required int? fielderMemberId { get; set; }

    [ProtoMember(8)]
    public required int ballLevel { get; set; }

    [ProtoMember(3)]
    public required bool isCovered { get; set; }

    [ProtoMember(9)]
    public required float coverPenalty { get; set; }

    [ProtoMember(10)]
    public required XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}