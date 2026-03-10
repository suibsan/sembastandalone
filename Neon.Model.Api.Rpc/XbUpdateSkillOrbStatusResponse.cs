
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbUpdateSkillOrbStatusResponse {
    [ProtoMember(1)]
    public XbSkillOrbInfo[] playerSkillOrbInfos { get; set; }

    [ProtoMember(2)]
    public XbSkillOrbInfo[] enemySkillOrbInfos { get; set; }

    [ProtoMember(3)]
    public XbGameInfo currentAtBatGameInfo { get; set; }

}