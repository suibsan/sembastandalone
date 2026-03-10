
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbErrorInfo {
    [ProtoMember(2)]
    public required bool isError { get; set; }

    [ProtoMember(6)]
    public required int? direction { get; set; }

    [ProtoMember(1)]
    public required int? fielderMemberId { get; set; }

    [ProtoMember(3)]
    public required float errorPenalty { get; set; }

    [ProtoMember(4)]
    public required XbRunningInfo[] runningInfos { get; set; }

    [ProtoMember(5)]
    public required XbGameSituationUpdateInfo afterGameSituation { get; set; }

    [ProtoMember(7)]
    public required XbBaseAdvanceInfo[] baseAdvanceInfos { get; set; }

}