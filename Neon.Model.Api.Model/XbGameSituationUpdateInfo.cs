
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbGameSituationUpdateInfo {
    [ProtoMember(13)]
    public int inning { get; set; }

    [ProtoMember(1)]
    public bool isTop { get; set; }

    [ProtoMember(19)]
    public bool isPlayerOffense { get; set; }

    [ProtoMember(14)]
    public int batterMemberId { get; set; }

    [ProtoMember(15)]
    public int pitcherMemberId { get; set; }

    [ProtoMember(3)]
    public int[] currentBaseSituation { get; set; }

    [ProtoMember(4)]
    public int topTeamScore { get; set; }

    [ProtoMember(5)]
    public int bottomTeamScore { get; set; }

    [ProtoMember(10)]
    public int currentOutCount { get; set; }

    [ProtoMember(11)]
    public bool isChange { get; set; }

    [ProtoMember(12)]
    public bool isGameSet { get; set; }

    [ProtoMember(16)]
    public bool isFirstAtBatInGame { get; set; }

    [ProtoMember(17)]
    public bool isFirstAtBatInHalfInning { get; set; }

    [ProtoMember(6)]
    public int eventOrder { get; set; }

}