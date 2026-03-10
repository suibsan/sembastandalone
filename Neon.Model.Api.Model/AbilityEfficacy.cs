
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AbilityEfficacy {
    [ProtoMember(1)]
    public int id { get; set; }

    [ProtoMember(2)]
    public int? abilityEfficacyGroupId { get; set; }

    [ProtoMember(3)]
    public int coolTimeMillisecond { get; set; }

    [ProtoMember(4)]
    public int effectCoolTimeMillisecond { get; set; }

    [ProtoMember(5)]
    public int activeTimeMillisecond { get; set; }

    [ProtoMember(6)]
    public int efficacyType { get; set; }

    [ProtoMember(7)]
    public int probability { get; set; }

    [ProtoMember(8)]
    public string activateConditions { get; set; }

    [ProtoMember(9)]
    public string deactivateConditions { get; set; }

    [ProtoMember(10)]
    public string sustainConditions { get; set; }

    [ProtoMember(11)]
    public string targetConditions { get; set; }

    [ProtoMember(12)]
    public float[] fValues { get; set; }

    [ProtoMember(13)]
    public int[] values { get; set; }

    [ProtoMember(14)]
    public int uiViewPriority { get; set; }

    [ProtoMember(15)]
    public float[] effectValueSteps { get; set; }

    [ProtoMember(16)]
    public int targetType { get; set; }

    [ProtoMember(17)]
    public int? maximumActiveTimeMillisecond { get; set; }

}