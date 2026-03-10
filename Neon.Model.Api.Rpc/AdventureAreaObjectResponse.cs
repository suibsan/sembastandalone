
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureAreaObjectResponse {
    [ProtoMember(1)]
    public required AreaObject[] areaObjects { get; set; }

    [ProtoMember(3)]
    public required AreaItem[] areaItems { get; set; }

    [ProtoMember(2)]
    public required BloodStain[] bloodStains { get; set; }

}