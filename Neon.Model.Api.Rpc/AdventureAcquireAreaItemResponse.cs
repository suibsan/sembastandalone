
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureAcquireAreaItemResponse {
    [ProtoMember(4)]
    public required AreaItem areaItem { get; set; }

    [ProtoMember(1)]
    public required Rewards[] rewards { get; set; }

    [ProtoMember(2)]
    public required Resources changedResources { get; set; }

    [ProtoMember(3)]
    public required AreaObject[] areaObjects { get; set; }

}