
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaSelectRequest {
    [ProtoMember(1)]
    public int gachaId { get; set; }

    [ProtoMember(2)]
    public int gachaCardId { get; set; }

}