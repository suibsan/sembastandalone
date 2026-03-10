
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BloodStainLocation {
    [ProtoMember(2)]
    public required int areaType { get; set; }

    [ProtoMember(1)]
    public required int areaKeyId { get; set; }

    [ProtoMember(3)]
    public required PositionCoordinates positionCoordinates { get; set; }

}