
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureAccessWarpPointRequest {
    [ProtoMember(1)]
    public required int warpPointId { get; set; }

    [ProtoMember(2)]
    public required CurrentLocation currentLocation { get; set; }

}