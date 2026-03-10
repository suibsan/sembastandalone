
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterMountingPowerCommon {
    [ProtoMember(2)]
    public required int value { get; set; }

}