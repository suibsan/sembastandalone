
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterItemPresentRequest {
    [ProtoMember(1)]
    public int characterId { get; set; }

    [ProtoMember(2)]
    public int itemId { get; set; }

    [ProtoMember(3)]
    public int quantity { get; set; }

}