
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaObjectAction {
    [ProtoMember(1)]
    public int type { get; set; }

    [ProtoMember(3)]
    public int id { get; set; }

    [ProtoMember(8)]
    public string label { get; set; }

    [ProtoMember(2)]
    public int? areaItemId { get; set; }

    [ProtoMember(4)]
    public int? areaEnemyId { get; set; }

    [ProtoMember(5)]
    public int? battleEntryId { get; set; }

    [ProtoMember(6)]
    public int? sequenceId { get; set; }

    [ProtoMember(12)]
    public int? graffitiArtId { get; set; }

    [ProtoMember(7)]
    public int? warpPointId { get; set; }

    [ProtoMember(9)]
    public int? fieldBossId { get; set; }

    [ProtoMember(10)]
    public int? dungeonId { get; set; }

    [ProtoMember(11)]
    public int? eventLiftId { get; set; }

}