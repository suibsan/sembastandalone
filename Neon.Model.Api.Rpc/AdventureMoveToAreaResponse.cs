
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureMoveToAreaResponse {
    [ProtoMember(1)]
    public Resources changedResources { get; set; }

    [ProtoMember(2)]
    public AreaChangeLock[] areaChangeLocks { get; set; }

    [ProtoMember(3)]
    public AreaBehavior areaBehavior { get; set; }

    [ProtoMember(4)]
    public AreaBgm areaBgm { get; set; }

}