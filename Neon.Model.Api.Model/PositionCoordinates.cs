
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PositionCoordinates {
    [ProtoMember(1)]
    public float x { get; set; }

    [ProtoMember(2)]
    public float y { get; set; }

    [ProtoMember(3)]
    public float z { get; set; }

}