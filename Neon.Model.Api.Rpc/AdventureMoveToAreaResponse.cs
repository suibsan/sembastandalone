
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureMoveToAreaResponse {
    [ProtoMember(1)]
    public required Resources changedResources { get; set; }

    [ProtoMember(2)]
    public required AreaChangeLock[] areaChangeLocks { get; set; }

    [ProtoMember(3)]
    public required AreaBehavior areaBehavior { get; set; }

    [ProtoMember(4)]
    public required AreaBgm areaBgm { get; set; }

}