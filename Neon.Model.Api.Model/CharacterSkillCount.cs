
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterSkillCount {
    [ProtoMember(1)]
    public int characterSkillId { get; set; }

    [ProtoMember(2)]
    public int count { get; set; }

}