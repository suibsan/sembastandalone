
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureMoveToAreaRequest {
    [ProtoMember(1)]
    public int areaId { get; set; }

    [ProtoMember(2)]
    public CurrentLocation currentLocation { get; set; }

    [ProtoMember(3)]
    public bool respawnAtHospital { get; set; }

}