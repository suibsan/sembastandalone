
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Enemy {
    [ProtoMember(1)]
    public int id { get; set; }

    [ProtoMember(6)]
    public int attack { get; set; }

    [ProtoMember(7)]
    public int defense { get; set; }

    [ProtoMember(8)]
    public int hp { get; set; }

    [ProtoMember(34)]
    public bool isSkipEncounterAnimation { get; set; }

    [ProtoMember(35)]
    public int? hpStackCount { get; set; }

}