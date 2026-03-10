
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CurrentLocation {
    [ProtoMember(2)]
    public required int? areaType { get; set; }

    [ProtoMember(5)]
    public required int? areaKeyId { get; set; }

    [ProtoMember(4)]
    public required PositionCoordinates positionCoordinates { get; set; }

    [ProtoMember(3)]
    public required int? direction { get; set; }

}