
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterCostume {
    [ProtoMember(1)]
    public int characterCostumeId { get; set; }

    [ProtoMember(2)]
    public DateTime? receivedAt { get; set; }

}