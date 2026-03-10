
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemUseSupplyGearEffectRequest {
    [ProtoMember(3)]
    public int itemId { get; set; }

    [ProtoMember(2)]
    public int baseGearEntityId { get; set; }

}