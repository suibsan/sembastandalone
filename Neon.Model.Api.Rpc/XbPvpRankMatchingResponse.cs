
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpRankMatchingResponse {
    [ProtoMember(1)]
    public required long? enemyUserId { get; set; }

    [ProtoMember(2)]
    public required int? enemyCpuUserId { get; set; }

}