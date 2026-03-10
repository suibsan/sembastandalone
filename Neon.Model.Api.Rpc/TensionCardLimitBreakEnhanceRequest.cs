
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TensionCardLimitBreakEnhanceRequest {
    [ProtoMember(1)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int[] consumedEntityIds { get; set; }

    [ProtoMember(3)]
    public ConsumedItem consumedItem { get; set; }

}