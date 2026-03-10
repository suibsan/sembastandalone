
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterEquipRequest {
    [ProtoMember(1)]
    public required int characterId { get; set; }

    [ProtoMember(2)]
    public required int? gearSlot1 { get; set; }

    [ProtoMember(3)]
    public required int? gearSlot2 { get; set; }

    [ProtoMember(4)]
    public required int? gearSlot3 { get; set; }

}