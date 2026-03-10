
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseNextAreaResponse {
    [ProtoMember(1)]
    public required FractalViseArea changedFractalViseArea { get; set; }

    [ProtoMember(4)]
    public required FractalViseNextAreaInfo[] nextAreaInfo { get; set; }

    [ProtoMember(2)]
    public required BloodStain[] bloodStains { get; set; }

    [ProtoMember(3)]
    public required Resources changedResources { get; set; }

}