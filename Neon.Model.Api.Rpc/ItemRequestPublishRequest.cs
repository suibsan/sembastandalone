
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequestPublishRequest {
    [ProtoMember(1)]
    public int deliveryRequestItemId { get; set; }

}