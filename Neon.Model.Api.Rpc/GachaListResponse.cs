
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaListResponse {
    [ProtoMember(1)]
    public required Gacha[] gachas { get; set; }

    [ProtoMember(2)]
    public required GachaRateSet[] gachaRateSets { get; set; }

    [ProtoMember(3)]
    public required GachaHistory[] gachaHistories { get; set; }

    [ProtoMember(4)]
    public required Resources changedResources { get; set; }

    [ProtoMember(5)]
    public required Character[] gachaCharacters { get; set; }

}