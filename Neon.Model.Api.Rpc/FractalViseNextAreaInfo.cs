
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseNextAreaInfo {
    [ProtoMember(1)]
    public required int fractalViseAreaId { get; set; }

    [ProtoMember(2)]
    public required float? clearRate { get; set; }

    [ProtoMember(3)]
    public required int treasureBoxAcquiredCount { get; set; }

    [ProtoMember(4)]
    public required int treasureBoxTotalCount { get; set; }

}