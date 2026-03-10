
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbLogicEventInfo {
    [ProtoMember(1)]
    public required int index { get; set; }

    [ProtoMember(2)]
    public required int timing { get; set; }

    [ProtoMember(3)]
    public required int eventOrder { get; set; }

    [ProtoMember(4)]
    public required XbSkillInfo skillInfo { get; set; }

    [ProtoMember(6)]
    public required XbTensionInfo[] tensionInfos { get; set; }

    [ProtoMember(5)]
    public required XbSkillOrbInfo[] playerSkillOrbInfos { get; set; }

    [ProtoMember(7)]
    public required XbSkillOrbInfo[] enemySkillOrbInfos { get; set; }

}