
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequest {
    [ProtoMember(1)]
    public long userId { get; set; }

    [ProtoMember(2)]
    public int deliveryRequestItemId { get; set; }

    [ProtoMember(3)]
    public DateTime? publishedAt { get; set; }

    [ProtoMember(4)]
    public DateTime? fulfilledAt { get; set; }

    [ProtoMember(5)]
    public bool isNew { get; set; }

}