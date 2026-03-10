
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpEntryResponse {
    [ProtoMember(2)]
    public XbPvpRankState rankMatchRankState { get; set; }

    [ProtoMember(3)]
    public bool isSeasonResetOccurred { get; set; }

    [ProtoMember(4)]
    public int prevSeasonRankPoint { get; set; }

}