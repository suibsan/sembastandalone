
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AbilityEfficacy {
    [ProtoMember(1)]
    public required int id { get; set; }

    [ProtoMember(2)]
    public required int? abilityEfficacyGroupId { get; set; }

    [ProtoMember(3)]
    public required int coolTimeMillisecond { get; set; }

    [ProtoMember(4)]
    public required int effectCoolTimeMillisecond { get; set; }

    [ProtoMember(5)]
    public required int activeTimeMillisecond { get; set; }

    [ProtoMember(6)]
    public required int efficacyType { get; set; }

    [ProtoMember(7)]
    public required int probability { get; set; }

    [ProtoMember(8)]
    public required string activateConditions { get; set; }

    [ProtoMember(9)]
    public required string deactivateConditions { get; set; }

    [ProtoMember(10)]
    public required string sustainConditions { get; set; }

    [ProtoMember(11)]
    public required string targetConditions { get; set; }

    [ProtoMember(12)]
    public required float[] fValues { get; set; }

    [ProtoMember(13)]
    public required int[] values { get; set; }

    [ProtoMember(14)]
    public required int uiViewPriority { get; set; }

    [ProtoMember(15)]
    public required float[] effectValueSteps { get; set; }

    [ProtoMember(16)]
    public required int targetType { get; set; }

    [ProtoMember(17)]
    public required int? maximumActiveTimeMillisecond { get; set; }

}