
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaSelectResponse {
    [ProtoMember(1)]
    public required Resources changedResources { get; set; }

    [ProtoMember(2)]
    public required GachaCategoryState gachaCategoryState { get; set; }

    [ProtoMember(3)]
    public required Reward[] receivedRewards { get; set; }

}