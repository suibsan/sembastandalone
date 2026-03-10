
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Gacha {
    [ProtoMember(1)]
    public required int gachaId { get; set; }

    [ProtoMember(2)]
    public required GachaButtonState[] gachaButtonStates { get; set; }

    [ProtoMember(3)]
    public required GachaCategoryState gachaCategoryState { get; set; }

}