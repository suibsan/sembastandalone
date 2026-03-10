
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaHistory {
    [ProtoMember(6)]
    public required int gachaCategoryId { get; set; }

    [ProtoMember(1)]
    public required int gachaId { get; set; }

    [ProtoMember(2)]
    public required int gachaButtonId { get; set; }

    [ProtoMember(3)]
    public required Resource[] costs { get; set; }

    [ProtoMember(4)]
    public required GachaReward[] drawnRewards { get; set; }

    [ProtoMember(5)]
    public required DateTime? executedAt { get; set; }

}