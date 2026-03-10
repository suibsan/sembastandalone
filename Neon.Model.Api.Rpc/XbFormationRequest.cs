
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbFormationRequest {
    [ProtoMember(1)]
    public int xbId { get; set; }

    [ProtoMember(2)]
    public long? enemyUserId { get; set; }

    [ProtoMember(3)]
    public int? enemyCpuUserId { get; set; }

}