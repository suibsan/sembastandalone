
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbTeam {
    [ProtoMember(1)]
    public string name { get; set; }

    [ProtoMember(6)]
    public string tribeLogoAasPath { get; set; }

    [ProtoMember(8)]
    public XbPvPUserInfo pvpUserInfo { get; set; }

    [ProtoMember(2)]
    public XbMember[] members { get; set; }

    [ProtoMember(3)]
    public bool batFirst { get; set; }

    [ProtoMember(4)]
    public bool isPlayerTeam { get; set; }

    [ProtoMember(7)]
    public int[] inningScores { get; set; }

    [ProtoMember(9)]
    public int currentBattingOrder { get; set; }

    [ProtoMember(14)]
    public XbZoneArea[] zoneAreas { get; set; }

    [ProtoMember(19)]
    public int? defaultZoneAreaIndex { get; set; }

    [ProtoMember(5)]
    public XbCommand selectedCommand { get; set; }

    [ProtoMember(16)]
    public float tensionValue { get; set; }

    [ProtoMember(17)]
    public int tensionLv { get; set; }

    [ProtoMember(18)]
    public bool isTensionMax { get; set; }

    [ProtoMember(10)]
    public XbBlockadeZoneAreaInfo blockadeZoneAreaInfo { get; set; }

    [ProtoMember(12)]
    public XbSkillOrbInfo[] skillOrbInfos { get; set; }

}