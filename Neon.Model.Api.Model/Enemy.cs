
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Enemy {
    [ProtoMember(1)]
    public required int id { get; set; }

    [ProtoMember(6)]
    public required int attack { get; set; }

    [ProtoMember(7)]
    public required int defense { get; set; }

    [ProtoMember(8)]
    public required int hp { get; set; }

    [ProtoMember(34)]
    public required bool isSkipEncounterAnimation { get; set; }

    [ProtoMember(35)]
    public required int? hpStackCount { get; set; }

}