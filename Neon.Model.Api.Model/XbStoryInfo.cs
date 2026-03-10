
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbStoryInfo {
    [ProtoMember(2)]
    public XbPhaseInfo phaseInfo { get; set; }

    [ProtoMember(3)]
    public XbLibrettoInfo librettoInfo { get; set; }

    [ProtoMember(5)]
    public XbCommandLockInfo commandLockInfo { get; set; }

    [ProtoMember(1)]
    public int[] blockadeCharacterWordsIds { get; set; }

    [ProtoMember(4)]
    public int? phaseClearProgressCount { get; set; }

    [ProtoMember(6)]
    public bool? isSuddenDeath { get; set; }

    [ProtoMember(7)]
    public bool? isSuddenDeathChanged { get; set; }

}