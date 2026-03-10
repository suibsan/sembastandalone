
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GearEnhanceRequest {
    [ProtoMember(1)]
    public required int gearEntityId { get; set; }

    [ProtoMember(2)]
    public required int[] consumedGearEntityIds { get; set; }

    [ProtoMember(3)]
    public required ConsumedItem[] consumedItems { get; set; }

}