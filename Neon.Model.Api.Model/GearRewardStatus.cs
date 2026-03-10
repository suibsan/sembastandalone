
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GearRewardStatus {
    [ProtoMember(5)]
    public required int[] subStatusIds { get; set; }

    [ProtoMember(6)]
    public required int gearRarity { get; set; }

}