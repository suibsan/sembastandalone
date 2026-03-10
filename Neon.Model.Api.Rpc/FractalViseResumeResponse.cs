
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseResumeResponse {
    [ProtoMember(8)]
    public FractalViseArea[] fractalViseAreas { get; set; }

    [ProtoMember(3)]
    public FractalViseNextAreaInfo[] nextAreaInfo { get; set; }

    [ProtoMember(2)]
    public BloodStain[] bloodStains { get; set; }

    [ProtoMember(4)]
    public FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(5)]
    public FractalViseMission[] fractalViseMissions { get; set; }

    [ProtoMember(7)]
    public Resources changedResources { get; set; }

}