
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRetireResponse {
    [ProtoMember(2)]
    public FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(3)]
    public FractalViseMission[] fractalViseMissions { get; set; }

    [ProtoMember(1)]
    public Resources changedResources { get; set; }

}