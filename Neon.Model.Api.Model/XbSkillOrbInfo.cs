
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSkillOrbInfo {
    [ProtoMember(1)]
    public int skillOrbId { get; set; }

    [ProtoMember(4)]
    public int status { get; set; }

    [ProtoMember(6)]
    public int prevStatus { get; set; }

    [ProtoMember(7)]
    public int restBrokenAtBatCount { get; set; }

}