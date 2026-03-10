
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbErrorInfo {
    [ProtoMember(2)]
    public bool isError { get; set; }

    [ProtoMember(6)]
    public int? direction { get; set; }

    [ProtoMember(1)]
    public int? fielderMemberId { get; set; }

    [ProtoMember(3)]
    public float errorPenalty { get; set; }

    [ProtoMember(4)]
    public XbRunningInfo[] runningInfos { get; set; }

    [ProtoMember(5)]
    public XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(7)]
    public XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}