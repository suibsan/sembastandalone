
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpEntryResponse {
    [ProtoMember(2)]
    public required XbPvpRankState rankMatchRankState { get; set; }

    [ProtoMember(3)]
    public required bool isSeasonResetOccurred { get; set; }

    [ProtoMember(4)]
    public required int prevSeasonRankPoint { get; set; }

}