
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CityReleaseGearShopRequest {
    [ProtoMember(1)]
    public required int cityId { get; set; }

}