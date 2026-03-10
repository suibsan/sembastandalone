
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class HappyWorkerCancelResponse {
    [ProtoMember(1)]
    public HappyWorkerItem happyWorkerItem { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

}