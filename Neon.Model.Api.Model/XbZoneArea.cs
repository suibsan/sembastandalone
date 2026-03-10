
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbZoneArea {
    [ProtoMember(1)]
    public int index { get; set; }

    [ProtoMember(6)]
    public XbSuggest[] playerSuggests { get; set; }

    [ProtoMember(8)]
    public XbSuggest[] enemySuggests { get; set; }

    [ProtoMember(7)]
    public XbCommand[] commands { get; set; }

}