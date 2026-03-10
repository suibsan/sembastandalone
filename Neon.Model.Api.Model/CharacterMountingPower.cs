
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterMountingPower {
    [ProtoMember(1)]
    public int characterId { get; set; }

    [ProtoMember(2)]
    public int value { get; set; }

}