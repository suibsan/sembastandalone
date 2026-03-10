
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbLogicEventInfo {
    [ProtoMember(1)]
    public int index { get; set; }

    [ProtoMember(2)]
    public int timing { get; set; }

    [ProtoMember(3)]
    public int eventOrder { get; set; }

    [ProtoMember(4)]
    public XbSkillInfo skillInfo { get; set; }

    [ProtoMember(6)]
    public XbTensionInfo[] tensionInfos { get; set; }

    [ProtoMember(5)]
    public XbSkillOrbInfo[] playerSkillOrbInfos { get; set; }

    [ProtoMember(7)]
    public XbSkillOrbInfo[] enemySkillOrbInfos { get; set; }

}