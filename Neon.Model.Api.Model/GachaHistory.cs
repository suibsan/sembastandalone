
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaHistory {
    [ProtoMember(6)]
    public int gachaCategoryId { get; set; }

    [ProtoMember(1)]
    public int gachaId { get; set; }

    [ProtoMember(2)]
    public int gachaButtonId { get; set; }

    [ProtoMember(3)]
    public Resource[] costs { get; set; }

    [ProtoMember(4)]
    public GachaReward[] drawnRewards { get; set; }

    [ProtoMember(5)]
    public DateTime? executedAt { get; set; }

}