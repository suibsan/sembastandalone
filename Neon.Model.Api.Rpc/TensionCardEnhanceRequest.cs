
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TensionCardEnhanceRequest {
    [ProtoMember(2)]
    public ConsumedItem[] consumedItems { get; set; }

    [ProtoMember(3)]
    public int entityId { get; set; }

}