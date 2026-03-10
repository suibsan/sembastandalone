
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaListResponse {
    [ProtoMember(1)]
    public Gacha[] gachas { get; set; }

    [ProtoMember(2)]
    public GachaRateSet[] gachaRateSets { get; set; }

    [ProtoMember(3)]
    public GachaHistory[] gachaHistories { get; set; }

    [ProtoMember(4)]
    public Resources changedResources { get; set; }

    [ProtoMember(5)]
    public Character[] gachaCharacters { get; set; }

}