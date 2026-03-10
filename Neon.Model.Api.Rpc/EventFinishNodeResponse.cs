
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class EventFinishNodeResponse {
    [ProtoMember(1)]
    public Reward[] rewards { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

}