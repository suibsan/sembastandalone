
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbFormationResponse {
    [ProtoMember(1)]
    public required XbMember[] playerMembers { get; set; }

    [ProtoMember(2)]
    public required XbMember[] enemyMembers { get; set; }

    [ProtoMember(3)]
    public required XbMember[] playerRecommendedMembers { get; set; }

    [ProtoMember(4)]
    public required XbMember[] allPlayerMembers { get; set; }

    [ProtoMember(5)]
    public required string playerTribeLogoAasPath { get; set; }

    [ProtoMember(6)]
    public required string enemyTribeLogoAasPath { get; set; }

    [ProtoMember(7)]
    public required string playerTeamName { get; set; }

    [ProtoMember(9)]
    public required string enemyTeamName { get; set; }

    [ProtoMember(8)]
    public required bool isTeamEditEnabled { get; set; }

    [ProtoMember(10)]
    public required XbPvPUserInfo playerPvpUserInfos { get; set; }

    [ProtoMember(11)]
    public required XbPvPUserInfo enemyPvpUserInfos { get; set; }

}