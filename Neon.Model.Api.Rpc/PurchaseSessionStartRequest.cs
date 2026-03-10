
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseSessionStartRequest {
    [ProtoMember(1)]
    public int shopProductId { get; set; }

}