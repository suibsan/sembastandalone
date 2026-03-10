
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BloodStainLocation {
    [ProtoMember(2)]
    public int areaType { get; set; }

    [ProtoMember(1)]
    public int areaKeyId { get; set; }

    [ProtoMember(3)]
    public PositionCoordinates positionCoordinates { get; set; }

}