
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaObjectAction {
    [ProtoMember(1)]
    public required int type { get; set; }

    [ProtoMember(3)]
    public required int id { get; set; }

    [ProtoMember(8)]
    public required string label { get; set; }

    [ProtoMember(2)]
    public required int? areaItemId { get; set; }

    [ProtoMember(4)]
    public required int? areaEnemyId { get; set; }

    [ProtoMember(5)]
    public required int? battleEntryId { get; set; }

    [ProtoMember(6)]
    public required int? sequenceId { get; set; }

    [ProtoMember(12)]
    public required int? graffitiArtId { get; set; }

    [ProtoMember(7)]
    public required int? warpPointId { get; set; }

    [ProtoMember(9)]
    public required int? fieldBossId { get; set; }

    [ProtoMember(10)]
    public required int? dungeonId { get; set; }

    [ProtoMember(11)]
    public required int? eventLiftId { get; set; }

}