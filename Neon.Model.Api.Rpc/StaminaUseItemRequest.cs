
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class StaminaUseItemRequest {
    [ProtoMember(1)]
    public required int itemId { get; set; }

    [ProtoMember(2)]
    public required int count { get; set; }

}