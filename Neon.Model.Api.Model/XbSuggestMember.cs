
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSuggestMember {
    [ProtoMember(1)]
    public required int index { get; set; }

    [ProtoMember(2)]
    public required int memberId { get; set; }

    [ProtoMember(3)]
    public required int suggestionId { get; set; }

    [ProtoMember(4)]
    public required int skillRank { get; set; }

}