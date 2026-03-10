
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSuggestMember {
    [ProtoMember(1)]
    public int index { get; set; }

    [ProtoMember(2)]
    public int memberId { get; set; }

    [ProtoMember(3)]
    public int suggestionId { get; set; }

    [ProtoMember(4)]
    public int skillRank { get; set; }

}