
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbUpdateSkillOrbStatusRequest {
    [ProtoMember(1)]
    public int xbId { get; set; }

    [ProtoMember(2)]
    public XbSkillOrbStatusRequest[] skillOrbStatuses { get; set; }

}