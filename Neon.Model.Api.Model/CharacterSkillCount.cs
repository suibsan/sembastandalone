
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterSkillCount {
    [ProtoMember(1)]
    public required int characterSkillId { get; set; }

    [ProtoMember(2)]
    public required int count { get; set; }

}