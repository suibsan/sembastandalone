
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbDefenseInfo {
    [ProtoMember(9)]
    public required int eventOrder { get; set; }

    [ProtoMember(1)]
    public required int targetRunnerMemberId { get; set; }

    [ProtoMember(2)]
    public required XbDefenseOwnBaseInfo defenseOwnBaseInfo { get; set; }

    [ProtoMember(3)]
    public required XbThrowingBallInfo throwingInfo { get; set; }

    [ProtoMember(4)]
    public required XbRunningInfo[] runningInfos { get; set; }

    [ProtoMember(5)]
    public required XbBoutInfo boutInfo { get; set; }

    [ProtoMember(6)]
    public required XbGameSituationUpdateInfo beforeGameSituation { get; set; }

    [ProtoMember(7)]
    public required XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(8)]
    public required XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}