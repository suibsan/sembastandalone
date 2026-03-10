
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbGameInfo {
    [ProtoMember(6)]
    public required int xbId { get; set; }

    [ProtoMember(5)]
    public required int index { get; set; }

    [ProtoMember(1)]
    public required XbTeam topTeam { get; set; }

    [ProtoMember(2)]
    public required XbTeam bottomTeam { get; set; }

    [ProtoMember(4)]
    public required XbAtBatEventInfo currentAtBatEventInfo { get; set; }

    [ProtoMember(7)]
    public required XbStoryInfo xbStoryInfo { get; set; }

    [ProtoMember(3)]
    public required XbPredictedTensionInfo[] predictedTensionInfos { get; set; }

    [ProtoMember(8)]
    public required XbClientStatus clientStatus { get; set; }

}