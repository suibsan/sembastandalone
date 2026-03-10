
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemUseSupplyGearEffectRequest {
    [ProtoMember(3)]
    public required int itemId { get; set; }

    [ProtoMember(2)]
    public required int baseGearEntityId { get; set; }

}