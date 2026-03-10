
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpRankMatchingResponse {
    [ProtoMember(1)]
    public long? enemyUserId { get; set; }

    [ProtoMember(2)]
    public int? enemyCpuUserId { get; set; }

}