
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSkillInfo {
    [ProtoMember(1)]
    public required bool isPlayer { get; set; }

    [ProtoMember(2)]
    public required int memberId { get; set; }

    [ProtoMember(3)]
    public required int skillId { get; set; }

}