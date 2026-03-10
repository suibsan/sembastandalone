
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRewardsReceiveMissionParam {
    [ProtoMember(1)]
    public int fractalViseId { get; set; }

    [ProtoMember(2)]
    public int[] fractalViseMissionIds { get; set; }

}