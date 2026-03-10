
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPhaseInfo {
    [ProtoMember(1)]
    public int phaseId { get; set; }

    [ProtoMember(2)]
    public bool isPhaseChanged { get; set; }

    [ProtoMember(3)]
    public string phaseSequencePath { get; set; }

    [ProtoMember(4)]
    public string themeSequencePath { get; set; }

    [ProtoMember(5)]
    public int[] correctTensionFluctuationIds { get; set; }

}