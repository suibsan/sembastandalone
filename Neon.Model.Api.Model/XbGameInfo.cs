
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbGameInfo {
    [ProtoMember(6)]
    public int xbId { get; set; }

    [ProtoMember(5)]
    public int index { get; set; }

    [ProtoMember(1)]
    public XbTeam topTeam { get; set; }

    [ProtoMember(2)]
    public XbTeam bottomTeam { get; set; }

    [ProtoMember(4)]
    public XbAtBatEventInfo currentAtBatEventInfo { get; set; }

    [ProtoMember(7)]
    public XbStoryInfo xbStoryInfo { get; set; }

    [ProtoMember(3)]
    public XbPredictedTensionInfo[] predictedTensionInfos { get; set; }

    [ProtoMember(8)]
    public XbClientStatus clientStatus { get; set; }

}