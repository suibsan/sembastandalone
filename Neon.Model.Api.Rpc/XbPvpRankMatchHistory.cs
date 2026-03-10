
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpRankMatchHistory {
    [ProtoMember(1)]
    public required bool isPlayerWon { get; set; }

    [ProtoMember(2)]
    public required XbPvPUserInfo enemyUserInfo { get; set; }

    [ProtoMember(3)]
    public required XbPvpMatchHistoryMember[] enemyFormationMembers { get; set; }

    [ProtoMember(4)]
    public required XbInningHalfScoreBoard[] scoreBoards { get; set; }

    [ProtoMember(5)]
    public required DateTime? executedAt { get; set; }

    [ProtoMember(6)]
    public required bool isCpuUser { get; set; }

}