
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSuggest {
    [ProtoMember(4)]
    public required int commandId { get; set; }

    [ProtoMember(5)]
    public required XbSuggestMember[] members { get; set; }

}