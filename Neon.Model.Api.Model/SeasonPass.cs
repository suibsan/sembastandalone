
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SeasonPass {
    [ProtoMember(1)]
    public int seasonId { get; set; }

    [ProtoMember(8)]
    public int purchaseState { get; set; }

    [ProtoMember(2)]
    public int exp { get; set; }

    [ProtoMember(3)]
    public int weeklyExp { get; set; }

    [ProtoMember(4)]
    public DateTime? weeklyExpResetAt { get; set; }

    [ProtoMember(5)]
    public int[] weeklyMissionIds { get; set; }

    [ProtoMember(6)]
    public int seasonMissionSheetId { get; set; }

}