
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbZoneArea {
    [ProtoMember(1)]
    public required int index { get; set; }

    [ProtoMember(6)]
    public required XbSuggest[] playerSuggests { get; set; }

    [ProtoMember(8)]
    public required XbSuggest[] enemySuggests { get; set; }

    [ProtoMember(7)]
    public required XbCommand[] commands { get; set; }

}