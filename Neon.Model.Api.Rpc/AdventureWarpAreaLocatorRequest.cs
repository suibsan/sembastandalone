
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureWarpAreaLocatorRequest {
    [ProtoMember(1)]
    public required int warpAreaType { get; set; }

    [ProtoMember(2)]
    public required int warpAreaId { get; set; }

}