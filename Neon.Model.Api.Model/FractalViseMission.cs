
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseMission {
    [ProtoMember(1)]
    public required int fractalViseMissionId { get; set; }

    [ProtoMember(2)]
    public required int fractalViseId { get; set; }

    [ProtoMember(3)]
    public required int count { get; set; }

    [ProtoMember(4)]
    public required DateTime? receivedAt { get; set; }

}