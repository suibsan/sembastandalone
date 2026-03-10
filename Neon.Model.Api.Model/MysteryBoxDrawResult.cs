
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MysteryBoxDrawResult {
    [ProtoMember(1)]
    public required int cardId { get; set; }

    [ProtoMember(2)]
    public required bool duplicate { get; set; }

}