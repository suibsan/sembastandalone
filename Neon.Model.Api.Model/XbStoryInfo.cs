
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbStoryInfo {
    [ProtoMember(2)]
    public required XbPhaseInfo phaseInfo { get; set; }

    [ProtoMember(3)]
    public required XbLibrettoInfo librettoInfo { get; set; }

    [ProtoMember(5)]
    public required XbCommandLockInfo commandLockInfo { get; set; }

    [ProtoMember(1)]
    public required int[] blockadeCharacterWordsIds { get; set; }

    [ProtoMember(4)]
    public required int? phaseClearProgressCount { get; set; }

    [ProtoMember(6)]
    public required bool? isSuddenDeath { get; set; }

    [ProtoMember(7)]
    public required bool? isSuddenDeathChanged { get; set; }

}