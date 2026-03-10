
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbMemberRequest {
    [ProtoMember(1)]
    public int? characterId { get; set; }

    [ProtoMember(5)]
    public int? xbCharacterId { get; set; }

    [ProtoMember(3)]
    public int battingOrder { get; set; }

    [ProtoMember(4)]
    public int position { get; set; }

}