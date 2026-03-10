
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbSuggest {
    [ProtoMember(4)]
    public int commandId { get; set; }

    [ProtoMember(5)]
    public XbSuggestMember[] members { get; set; }

}