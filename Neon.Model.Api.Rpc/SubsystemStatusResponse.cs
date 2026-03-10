
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SubsystemStatusResponse {
    [ProtoMember(1)]
    public SubsystemStatus shop { get; set; }

    [ProtoMember(2)]
    public SubsystemStatus gacha { get; set; }

}