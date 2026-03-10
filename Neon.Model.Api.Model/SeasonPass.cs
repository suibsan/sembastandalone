
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SeasonPass {
    [ProtoMember(1)]
    public required int seasonId { get; set; }

    [ProtoMember(8)]
    public required int purchaseState { get; set; }

    [ProtoMember(2)]
    public required int exp { get; set; }

    [ProtoMember(3)]
    public required int weeklyExp { get; set; }

    [ProtoMember(4)]
    public required DateTime? weeklyExpResetAt { get; set; }

    [ProtoMember(5)]
    public required int[] weeklyMissionIds { get; set; }

    [ProtoMember(6)]
    public required int seasonMissionSheetId { get; set; }

}