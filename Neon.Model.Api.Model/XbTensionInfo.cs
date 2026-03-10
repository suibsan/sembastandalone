
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbTensionInfo {
    [ProtoMember(12)]
    public required bool isPlayer { get; set; }

    [ProtoMember(9)]
    public required int? skitIndex { get; set; }

    [ProtoMember(3)]
    public required float tensionValue { get; set; }

    [ProtoMember(4)]
    public required int tensionLv { get; set; }

    [ProtoMember(11)]
    public required int? runnerMemberId { get; set; }

    [ProtoMember(5)]
    public required bool isTensionMax { get; set; }

    [ProtoMember(6)]
    public required float previousTensionValue { get; set; }

    [ProtoMember(7)]
    public required int previousTensionLv { get; set; }

    [ProtoMember(8)]
    public required bool previousIsTensionMax { get; set; }

}