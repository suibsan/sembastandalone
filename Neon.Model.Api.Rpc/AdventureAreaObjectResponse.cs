
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureAreaObjectResponse {
    [ProtoMember(1)]
    public AreaObject[] areaObjects { get; set; }

    [ProtoMember(3)]
    public AreaItem[] areaItems { get; set; }

    [ProtoMember(2)]
    public BloodStain[] bloodStains { get; set; }

}