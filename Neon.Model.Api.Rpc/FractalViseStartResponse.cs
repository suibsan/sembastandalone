
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseStartResponse {
    [ProtoMember(5)]
    public FractalViseArea[] fractalViseAreas { get; set; }

    [ProtoMember(4)]
    public FractalViseNextAreaInfo[] nextAreaInfo { get; set; }

    [ProtoMember(2)]
    public BloodStain[] bloodStains { get; set; }

    [ProtoMember(3)]
    public Resources changedResources { get; set; }

}