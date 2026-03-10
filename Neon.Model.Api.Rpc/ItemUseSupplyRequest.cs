
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemUseSupplyRequest {
    [ProtoMember(3)]
    public int itemId { get; set; }

    [ProtoMember(4)]
    public int count { get; set; }

    [ProtoMember(2)]
    public int? characterId { get; set; }

}