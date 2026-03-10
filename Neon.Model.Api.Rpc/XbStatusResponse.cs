
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbStatusResponse {
    [ProtoMember(1)]
    public required XbGameInfo currentAtBatGameInfo { get; set; }

}