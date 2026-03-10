
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CurrentLocation {
    [ProtoMember(2)]
    public int? areaType { get; set; }

    [ProtoMember(5)]
    public int? areaKeyId { get; set; }

    [ProtoMember(4)]
    public PositionCoordinates positionCoordinates { get; set; }

    [ProtoMember(3)]
    public int? direction { get; set; }

}