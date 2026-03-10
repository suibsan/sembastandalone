
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbMember {
    [ProtoMember(1)]
    public required int? memberId { get; set; }

    [ProtoMember(3)]
    public required int xbBaseCharacterId { get; set; }

    [ProtoMember(16)]
    public required int? xbCharacterId { get; set; }

    [ProtoMember(13)]
    public required int? characterId { get; set; }

    [ProtoMember(15)]
    public required int characterAssetId { get; set; }

    [ProtoMember(4)]
    public required int level { get; set; }

    [ProtoMember(5)]
    public required int? position { get; set; }

    [ProtoMember(6)]
    public required int? battingOrder { get; set; }

    [ProtoMember(17)]
    public required int[] skillIds { get; set; }

    [ProtoMember(18)]
    public required string displayLevel { get; set; }

    [ProtoMember(31)]
    public required int? maxHp { get; set; }

    [ProtoMember(32)]
    public required int? attack { get; set; }

    [ProtoMember(33)]
    public required int? defense { get; set; }

    [ProtoMember(7)]
    public required int[] characterSkillPanelLevels { get; set; }

    [ProtoMember(19)]
    public required bool isGuest { get; set; }

    [ProtoMember(20)]
    public required bool isDisable { get; set; }

    [ProtoMember(30)]
    public required bool isVisible { get; set; }

    [ProtoMember(2)]
    public required bool isHologram { get; set; }

}