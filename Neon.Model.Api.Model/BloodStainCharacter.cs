
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BloodStainCharacter {
    [ProtoMember(1)]
    public int characterId { get; set; }

    [ProtoMember(2)]
    public int exp { get; set; }

    [ProtoMember(3)]
    public int rank { get; set; }

    [ProtoMember(4)]
    public int? characterCostumeId { get; set; }

}