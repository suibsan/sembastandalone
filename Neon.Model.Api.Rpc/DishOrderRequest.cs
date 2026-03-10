
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DishOrderRequest {
    [ProtoMember(1)]
    public int dishId { get; set; }

    [ProtoMember(2)]
    public CurrentLocation currentLocation { get; set; }

}