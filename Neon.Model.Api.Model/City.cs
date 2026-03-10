
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class City {
    [ProtoMember(1)]
    public int cityId { get; set; }

    [ProtoMember(2)]
    public bool isGearShopReleased { get; set; }

    [ProtoMember(3)]
    public DateTime? releasedAt { get; set; }

}