
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBoutInfo {
    [ProtoMember(1)]
    public required bool boutOccurred { get; set; }

    [ProtoMember(2)]
    public required int baseNumOfBout { get; set; }

    [ProtoMember(3)]
    public required int baseNumOfRunner { get; set; }

    [ProtoMember(4)]
    public required int runnerMemberId { get; set; }

    [ProtoMember(6)]
    public required int fielderMemberId { get; set; }

    [ProtoMember(7)]
    public required bool isTouchOut { get; set; }

    [ProtoMember(8)]
    public required XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}