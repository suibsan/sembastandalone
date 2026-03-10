
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbAddCommandUnlockItemRequest {
    [ProtoMember(1)]
    public int xbId { get; set; }

    [ProtoMember(4)]
    public int magicOrbId { get; set; }

    [ProtoMember(3)]
    public int quantity { get; set; }

}