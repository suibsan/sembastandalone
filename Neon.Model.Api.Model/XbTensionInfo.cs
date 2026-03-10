
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbTensionInfo {
    [ProtoMember(12)]
    public bool isPlayer { get; set; }

    [ProtoMember(9)]
    public int? skitIndex { get; set; }

    [ProtoMember(3)]
    public float tensionValue { get; set; }

    [ProtoMember(4)]
    public int tensionLv { get; set; }

    [ProtoMember(11)]
    public int? runnerMemberId { get; set; }

    [ProtoMember(5)]
    public bool isTensionMax { get; set; }

    [ProtoMember(6)]
    public float previousTensionValue { get; set; }

    [ProtoMember(7)]
    public int previousTensionLv { get; set; }

    [ProtoMember(8)]
    public bool previousIsTensionMax { get; set; }

}