
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbMember {
    [ProtoMember(1)]
    public int? memberId { get; set; }

    [ProtoMember(3)]
    public int xbBaseCharacterId { get; set; }

    [ProtoMember(16)]
    public int? xbCharacterId { get; set; }

    [ProtoMember(13)]
    public int? characterId { get; set; }

    [ProtoMember(15)]
    public int characterAssetId { get; set; }

    [ProtoMember(4)]
    public int level { get; set; }

    [ProtoMember(5)]
    public int? position { get; set; }

    [ProtoMember(6)]
    public int? battingOrder { get; set; }

    [ProtoMember(17)]
    public int[] skillIds { get; set; }

    [ProtoMember(18)]
    public string displayLevel { get; set; }

    [ProtoMember(31)]
    public int? maxHp { get; set; }

    [ProtoMember(32)]
    public int? attack { get; set; }

    [ProtoMember(33)]
    public int? defense { get; set; }

    [ProtoMember(7)]
    public int[] characterSkillPanelLevels { get; set; }

    [ProtoMember(19)]
    public bool isGuest { get; set; }

    [ProtoMember(20)]
    public bool isDisable { get; set; }

    [ProtoMember(30)]
    public bool isVisible { get; set; }

    [ProtoMember(2)]
    public bool isHologram { get; set; }

}