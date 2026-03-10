
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ResourceParams {
    [ProtoMember(1)]
    public int? oldLimitBreak { get; set; }

    [ProtoMember(2)]
    public int? newLimitBreak { get; set; }

    [ProtoMember(3)]
    public GearRewardStatus gearRewardStatus { get; set; }

    [ProtoMember(4)]
    public GearSubStatus gearSubStatusDraw { get; set; }

    [ProtoMember(5)]
    public MysteryBoxDrawResults mysteryBoxDrawResults { get; set; }

}