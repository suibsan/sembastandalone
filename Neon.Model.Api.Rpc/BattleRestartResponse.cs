
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleRestartResponse {
    [ProtoMember(2)]
    public Character[] characters { get; set; }

    [ProtoMember(4)]
    public TensionCard[] tensionCards { get; set; }

    [ProtoMember(5)]
    public BattleParameter[] battleParameters { get; set; }

    [ProtoMember(6)]
    public BattleTrigger[] battleTriggers { get; set; }

    [ProtoMember(7)]
    public BattleAdvantageType advantageType { get; set; }

    [ProtoMember(9)]
    public CharacterDish[] characterDishes { get; set; }

    [ProtoMember(10)]
    public BattleWonResultType wonResultType { get; set; }

    [ProtoMember(11)]
    public int? abilityEnigmaId { get; set; }

    [ProtoMember(12)]
    public Resources changedResources { get; set; }

    [ProtoMember(13)]
    public GuestCharacter[] guestCharacters { get; set; }

    [ProtoMember(14)]
    public int difficultyDecreaseCount { get; set; }

}