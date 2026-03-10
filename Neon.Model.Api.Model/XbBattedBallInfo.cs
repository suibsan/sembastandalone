
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBattedBallInfo {
    [ProtoMember(1)]
    public int? direction { get; set; }

    [ProtoMember(2)]
    public bool isInfield { get; set; }

    [ProtoMember(4)]
    public XbRunningInfo[] runningInfos { get; set; }

    [ProtoMember(5)]
    public float time { get; set; }

    [ProtoMember(6)]
    public XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(7)]
    public int? fielderMemberId { get; set; }

    [ProtoMember(8)]
    public int ballLevel { get; set; }

    [ProtoMember(3)]
    public bool isCovered { get; set; }

    [ProtoMember(9)]
    public float coverPenalty { get; set; }

    [ProtoMember(10)]
    public XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}