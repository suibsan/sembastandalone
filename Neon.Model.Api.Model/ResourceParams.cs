
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ResourceParams {
    [ProtoMember(1)]
    public required int? oldLimitBreak { get; set; }

    [ProtoMember(2)]
    public required int? newLimitBreak { get; set; }

    [ProtoMember(3)]
    public required GearRewardStatus gearRewardStatus { get; set; }

    [ProtoMember(4)]
    public required GearSubStatus gearSubStatusDraw { get; set; }

    [ProtoMember(5)]
    public required MysteryBoxDrawResults mysteryBoxDrawResults { get; set; }

}