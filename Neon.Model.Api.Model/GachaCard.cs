
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaCard {
    [ProtoMember(1)]
    public required int cardType { get; set; }

    [ProtoMember(2)]
    public required int cardId { get; set; }

    [ProtoMember(3)]
    public required bool isAttention { get; set; }

    [ProtoMember(4)]
    public required bool isSelectable { get; set; }

    [ProtoMember(5)]
    public required int gachaCardId { get; set; }

}