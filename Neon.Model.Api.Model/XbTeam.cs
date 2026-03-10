
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbTeam {
    [ProtoMember(1)]
    public required string name { get; set; }

    [ProtoMember(6)]
    public required string tribeLogoAasPath { get; set; }

    [ProtoMember(8)]
    public required XbPvPUserInfo pvpUserInfo { get; set; }

    [ProtoMember(2)]
    public required XbMember[] members { get; set; }

    [ProtoMember(3)]
    public required bool batFirst { get; set; }

    [ProtoMember(4)]
    public required bool isPlayerTeam { get; set; }

    [ProtoMember(7)]
    public required int[] inningScores { get; set; }

    [ProtoMember(9)]
    public required int currentBattingOrder { get; set; }

    [ProtoMember(14)]
    public required XbZoneArea[] zoneAreas { get; set; }

    [ProtoMember(19)]
    public required int? defaultZoneAreaIndex { get; set; }

    [ProtoMember(5)]
    public required XbCommand selectedCommand { get; set; }

    [ProtoMember(16)]
    public required float tensionValue { get; set; }

    [ProtoMember(17)]
    public required int tensionLv { get; set; }

    [ProtoMember(18)]
    public required bool isTensionMax { get; set; }

    [ProtoMember(10)]
    public required XbBlockadeZoneAreaInfo blockadeZoneAreaInfo { get; set; }

    [ProtoMember(12)]
    public required XbSkillOrbInfo[] skillOrbInfos { get; set; }

}