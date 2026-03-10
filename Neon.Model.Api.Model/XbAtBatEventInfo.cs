
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbAtBatEventInfo {
    [ProtoMember(1)]
    public XbBattingInfo battingInfo { get; set; }

    [ProtoMember(2)]
    public XbBattedBallInfo battedBallInfo { get; set; }

    [ProtoMember(8)]
    public XbErrorInfo errorInfo { get; set; }

    [ProtoMember(3)]
    public XbDefenseInfo[] defenseInfos { get; set; }

    [ProtoMember(4)]
    public XbGameSituationUpdateInfo beforeGameSituation { get; set; }

    [ProtoMember(5)]
    public XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(12)]
    public XbLogicEventInfo[] logicEventInfos { get; set; }

    [ProtoMember(6)]
    public XbBuffInfo[] buffInfos { get; set; }

}