
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPredictedTensionInfo {
    [ProtoMember(1)]
    public int zoneAreaIndex { get; set; }

    [ProtoMember(2)]
    public int commandId { get; set; }

    [ProtoMember(3)]
    public bool isPlayer { get; set; }

    [ProtoMember(4)]
    public float tensionValue { get; set; }

    [ProtoMember(5)]
    public int tensionLv { get; set; }

    [ProtoMember(6)]
    public bool isTensionMax { get; set; }

}