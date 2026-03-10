
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbUpdateTensionResponse {
    [ProtoMember(2)]
    public XbTensionInfo[] playerTensionInfos { get; set; }

    [ProtoMember(3)]
    public XbTensionInfo[] enemyTensionInfos { get; set; }

    [ProtoMember(1)]
    public XbGameInfo currentAtBatGameInfo { get; set; }

}