
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SeasonPassReceiveRequest {
    [ProtoMember(1)]
    public int seasonId { get; set; }

    [ProtoMember(2)]
    public int seasonPassTierId { get; set; }

    [ProtoMember(3)]
    public int seasonPassType { get; set; }

}