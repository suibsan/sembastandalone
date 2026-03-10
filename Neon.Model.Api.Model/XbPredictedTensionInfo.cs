
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPredictedTensionInfo {
    [ProtoMember(1)]
    public required int zoneAreaIndex { get; set; }

    [ProtoMember(2)]
    public required int commandId { get; set; }

    [ProtoMember(3)]
    public required bool isPlayer { get; set; }

    [ProtoMember(4)]
    public required float tensionValue { get; set; }

    [ProtoMember(5)]
    public required int tensionLv { get; set; }

    [ProtoMember(6)]
    public required bool isTensionMax { get; set; }

}