
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaCard {
    [ProtoMember(1)]
    public int cardType { get; set; }

    [ProtoMember(2)]
    public int cardId { get; set; }

    [ProtoMember(3)]
    public bool isAttention { get; set; }

    [ProtoMember(4)]
    public bool isSelectable { get; set; }

    [ProtoMember(5)]
    public int gachaCardId { get; set; }

}