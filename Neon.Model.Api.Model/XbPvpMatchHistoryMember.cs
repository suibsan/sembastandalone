
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpMatchHistoryMember {
    [ProtoMember(1)]
    public required int? characterId { get; set; }

    [ProtoMember(2)]
    public required int? xbCharacterId { get; set; }

    [ProtoMember(3)]
    public required int? characterAssetId { get; set; }

    [ProtoMember(4)]
    public required int? position { get; set; }

}