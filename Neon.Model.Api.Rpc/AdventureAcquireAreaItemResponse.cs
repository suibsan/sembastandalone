
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureAcquireAreaItemResponse {
    [ProtoMember(4)]
    public AreaItem areaItem { get; set; }

    [ProtoMember(1)]
    public Rewards[] rewards { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

    [ProtoMember(3)]
    public AreaObject[] areaObjects { get; set; }

}