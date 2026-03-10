
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbStartResponse {
    [ProtoMember(8)]
    public required XbGameInfo nextAtBatGameInfo { get; set; }

}