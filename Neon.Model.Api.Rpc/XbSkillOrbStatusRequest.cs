
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSkillOrbStatusRequest {
    [ProtoMember(1)]
    public required bool isPlayer { get; set; }

    [ProtoMember(2)]
    public required int type { get; set; }

    [ProtoMember(3)]
    public required int status { get; set; }

    [ProtoMember(4)]
    public required int? brokenAtBatCount { get; set; }

}