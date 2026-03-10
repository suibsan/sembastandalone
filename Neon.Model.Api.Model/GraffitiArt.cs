
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GraffitiArt {
    [ProtoMember(1)]
    public required int graffitiArtId { get; set; }

}