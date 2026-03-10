
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseResumeResponse {
    [ProtoMember(8)]
    public required FractalViseArea[] fractalViseAreas { get; set; }

    [ProtoMember(3)]
    public required FractalViseNextAreaInfo[] nextAreaInfo { get; set; }

    [ProtoMember(2)]
    public required BloodStain[] bloodStains { get; set; }

    [ProtoMember(4)]
    public required FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(5)]
    public required FractalViseMission[] fractalViseMissions { get; set; }

    [ProtoMember(7)]
    public required Resources changedResources { get; set; }

}