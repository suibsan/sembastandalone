
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaExecuteRequest {
    [ProtoMember(1)]
    public int gachaId { get; set; }

    [ProtoMember(2)]
    public int gachaButtonId { get; set; }

    [ProtoMember(3)]
    public DateTime? clientTimestamp { get; set; }

}