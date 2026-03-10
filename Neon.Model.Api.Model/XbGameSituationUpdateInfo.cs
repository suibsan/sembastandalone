
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbGameSituationUpdateInfo {
    [ProtoMember(13)]
    public required int inning { get; set; }

    [ProtoMember(1)]
    public required bool isTop { get; set; }

    [ProtoMember(19)]
    public required bool isPlayerOffense { get; set; }

    [ProtoMember(14)]
    public required int batterMemberId { get; set; }

    [ProtoMember(15)]
    public required int pitcherMemberId { get; set; }

    [ProtoMember(3)]
    public required int[] currentBaseSituation { get; set; }

    [ProtoMember(4)]
    public required int topTeamScore { get; set; }

    [ProtoMember(5)]
    public required int bottomTeamScore { get; set; }

    [ProtoMember(10)]
    public required int currentOutCount { get; set; }

    [ProtoMember(11)]
    public required bool isChange { get; set; }

    [ProtoMember(12)]
    public required bool isGameSet { get; set; }

    [ProtoMember(16)]
    public required bool isFirstAtBatInGame { get; set; }

    [ProtoMember(17)]
    public required bool isFirstAtBatInHalfInning { get; set; }

    [ProtoMember(6)]
    public required int eventOrder { get; set; }

}