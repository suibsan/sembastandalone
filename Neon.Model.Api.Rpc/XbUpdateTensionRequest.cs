
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbUpdateTensionRequest {
    [ProtoMember(1)]
    public required int xbId { get; set; }

    [ProtoMember(2)]
    public required int[] tensionFluctuationIds { get; set; }

}