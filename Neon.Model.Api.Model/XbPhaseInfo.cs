
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPhaseInfo {
    [ProtoMember(1)]
    public required int phaseId { get; set; }

    [ProtoMember(2)]
    public required bool isPhaseChanged { get; set; }

    [ProtoMember(3)]
    public required string phaseSequencePath { get; set; }

    [ProtoMember(4)]
    public required string themeSequencePath { get; set; }

    [ProtoMember(5)]
    public required int[] correctTensionFluctuationIds { get; set; }

}