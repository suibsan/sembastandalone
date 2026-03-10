
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaButtonState {
    [ProtoMember(1)]
    public int gachaId { get; set; }

    [ProtoMember(2)]
    public int gachaButtonId { get; set; }

    [ProtoMember(3)]
    public int executionCount { get; set; }

    [ProtoMember(4)]
    public DateTime? lastExecutedAt { get; set; }

}