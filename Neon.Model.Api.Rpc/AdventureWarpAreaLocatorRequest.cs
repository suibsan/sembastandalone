
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureWarpAreaLocatorRequest {
    [ProtoMember(1)]
    public int warpAreaType { get; set; }

    [ProtoMember(2)]
    public int warpAreaId { get; set; }

}