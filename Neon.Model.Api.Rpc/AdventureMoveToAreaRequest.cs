
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureMoveToAreaRequest {
    [ProtoMember(1)]
    public required int areaId { get; set; }

    [ProtoMember(2)]
    public required CurrentLocation currentLocation { get; set; }

    [ProtoMember(3)]
    public required bool respawnAtHospital { get; set; }

}