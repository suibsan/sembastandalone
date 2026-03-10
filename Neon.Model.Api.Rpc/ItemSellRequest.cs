
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemSellRequest {
    [ProtoMember(1)]
    public ConsumedItem[] items { get; set; }

}