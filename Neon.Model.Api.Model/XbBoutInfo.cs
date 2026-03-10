
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBoutInfo {
    [ProtoMember(1)]
    public bool boutOccurred { get; set; }

    [ProtoMember(2)]
    public int baseNumOfBout { get; set; }

    [ProtoMember(3)]
    public int baseNumOfRunner { get; set; }

    [ProtoMember(4)]
    public int runnerMemberId { get; set; }

    [ProtoMember(6)]
    public int fielderMemberId { get; set; }

    [ProtoMember(7)]
    public bool isTouchOut { get; set; }

    [ProtoMember(8)]
    public XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}