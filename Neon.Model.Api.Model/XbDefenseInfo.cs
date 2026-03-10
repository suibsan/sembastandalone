
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbDefenseInfo {
    [ProtoMember(9)]
    public int eventOrder { get; set; }

    [ProtoMember(1)]
    public int targetRunnerMemberId { get; set; }

    [ProtoMember(2)]
    public XbDefenseOwnBaseInfo defenseOwnBaseInfo { get; set; }

    [ProtoMember(3)]
    public XbThrowingBallInfo throwingInfo { get; set; }

    [ProtoMember(4)]
    public XbRunningInfo[] runningInfos { get; set; }

    [ProtoMember(5)]
    public XbBoutInfo boutInfo { get; set; }

    [ProtoMember(6)]
    public XbGameSituationUpdateInfo beforeGameSituation { get; set; }

    [ProtoMember(7)]
    public XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(8)]
    public XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}