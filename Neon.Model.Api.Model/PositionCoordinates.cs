
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PositionCoordinates {
    [ProtoMember(1)]
    public required float x { get; set; }

    [ProtoMember(2)]
    public required float y { get; set; }

    [ProtoMember(3)]
    public required float z { get; set; }

}