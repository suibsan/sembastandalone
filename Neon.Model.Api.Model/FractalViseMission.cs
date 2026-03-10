
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseMission {
    [ProtoMember(1)]
    public int fractalViseMissionId { get; set; }

    [ProtoMember(2)]
    public int fractalViseId { get; set; }

    [ProtoMember(3)]
    public int count { get; set; }

    [ProtoMember(4)]
    public DateTime? receivedAt { get; set; }

}