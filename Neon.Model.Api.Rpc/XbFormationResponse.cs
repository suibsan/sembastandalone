
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbFormationResponse {
    [ProtoMember(1)]
    public XbMember[] playerMembers { get; set; }

    [ProtoMember(2)]
    public XbMember[] enemyMembers { get; set; }

    [ProtoMember(3)]
    public XbMember[] playerRecommendedMembers { get; set; }

    [ProtoMember(4)]
    public XbMember[] allPlayerMembers { get; set; }

    [ProtoMember(5)]
    public string playerTribeLogoAasPath { get; set; }

    [ProtoMember(6)]
    public string enemyTribeLogoAasPath { get; set; }

    [ProtoMember(7)]
    public string playerTeamName { get; set; }

    [ProtoMember(9)]
    public string enemyTeamName { get; set; }

    [ProtoMember(8)]
    public bool isTeamEditEnabled { get; set; }

    [ProtoMember(10)]
    public XbPvPUserInfo playerPvpUserInfos { get; set; }

    [ProtoMember(11)]
    public XbPvPUserInfo enemyPvpUserInfos { get; set; }

}