
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpRankMatchHistory {
    [ProtoMember(1)]
    public bool isPlayerWon { get; set; }

    [ProtoMember(2)]
    public XbPvPUserInfo enemyUserInfo { get; set; }

    [ProtoMember(3)]
    public XbPvpMatchHistoryMember[] enemyFormationMembers { get; set; }

    [ProtoMember(4)]
    public XbInningHalfScoreBoard[] scoreBoards { get; set; }

    [ProtoMember(5)]
    public DateTime? executedAt { get; set; }

    [ProtoMember(6)]
    public bool isCpuUser { get; set; }

}