
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbAtBatEventInfo {
    [ProtoMember(1)]
    public required XbBattingInfo battingInfo { get; set; }

    [ProtoMember(2)]
    public required XbBattedBallInfo battedBallInfo { get; set; }

    [ProtoMember(8)]
    public required XbErrorInfo errorInfo { get; set; }

    [ProtoMember(3)]
    public required XbDefenseInfo[] defenseInfos { get; set; }

    [ProtoMember(4)]
    public required XbGameSituationUpdateInfo beforeGameSituation { get; set; }

    [ProtoMember(5)]
    public required XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(12)]
    public required XbLogicEventInfo[] logicEventInfos { get; set; }

    [ProtoMember(6)]
    public required XbBuffInfo[] buffInfos { get; set; }

}