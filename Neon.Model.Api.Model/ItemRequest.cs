
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequest {
    [ProtoMember(1)]
    public required long userId { get; set; }

    [ProtoMember(2)]
    public required int deliveryRequestItemId { get; set; }

    [ProtoMember(3)]
    public required DateTime? publishedAt { get; set; }

    [ProtoMember(4)]
    public required DateTime? fulfilledAt { get; set; }

    [ProtoMember(5)]
    public required bool isNew { get; set; }

}