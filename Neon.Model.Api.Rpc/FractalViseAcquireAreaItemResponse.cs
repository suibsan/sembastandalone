
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseAcquireAreaItemResponse {
    [ProtoMember(1)]
    public required FractalViseArea changedFractalViseArea { get; set; }

    [ProtoMember(2)]
    public required Rewards[] rewards { get; set; }

    [ProtoMember(3)]
    public required Resources changedResources { get; set; }

}