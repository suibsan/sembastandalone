
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterDish {
    [ProtoMember(1)]
    public int characterId { get; set; }

    [ProtoMember(2)]
    public int dishId { get; set; }

    [ProtoMember(3)]
    public int dishEffectCount { get; set; }

}