
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowUserCharacter {
    [ProtoMember(1)]
    public required int characterId { get; set; }

    [ProtoMember(2)]
    public required int? characterCostumeId { get; set; }

}