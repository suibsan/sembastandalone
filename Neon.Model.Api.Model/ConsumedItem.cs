
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ConsumedItem {
    [ProtoMember(1)]
    public int itemId { get; set; }

    [ProtoMember(2)]
    public int quantity { get; set; }

}