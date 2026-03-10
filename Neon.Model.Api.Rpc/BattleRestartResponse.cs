
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleRestartResponse {
    [ProtoMember(2)]
    public required Character[] characters { get; set; }

    [ProtoMember(4)]
    public required TensionCard[] tensionCards { get; set; }

    [ProtoMember(5)]
    public required BattleParameter[] battleParameters { get; set; }

    [ProtoMember(6)]
    public required BattleTrigger[] battleTriggers { get; set; }

    [ProtoMember(7)]
    public required BattleAdvantageType advantageType { get; set; }

    [ProtoMember(9)]
    public required CharacterDish[] characterDishes { get; set; }

    [ProtoMember(10)]
    public required BattleWonResultType wonResultType { get; set; }

    [ProtoMember(11)]
    public required int? abilityEnigmaId { get; set; }

    [ProtoMember(12)]
    public required Resources changedResources { get; set; }

    [ProtoMember(13)]
    public required GuestCharacter[] guestCharacters { get; set; }

    [ProtoMember(14)]
    public required int difficultyDecreaseCount { get; set; }

}