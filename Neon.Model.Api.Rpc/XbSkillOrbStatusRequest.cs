
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSkillOrbStatusRequest {
    [ProtoMember(1)]
    public bool isPlayer { get; set; }

    [ProtoMember(2)]
    public int type { get; set; }

    [ProtoMember(3)]
    public int status { get; set; }

    [ProtoMember(4)]
    public int? brokenAtBatCount { get; set; }

}