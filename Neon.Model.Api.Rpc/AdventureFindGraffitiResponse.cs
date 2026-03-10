
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureFindGraffitiResponse {
    [ProtoMember(2)]
    public Reward[] rewards { get; set; }

    [ProtoMember(3)]
    public Resources changedResources { get; set; }

}