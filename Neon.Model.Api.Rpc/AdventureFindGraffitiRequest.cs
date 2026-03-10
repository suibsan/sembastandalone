
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureFindGraffitiRequest {
    [ProtoMember(1)]
    public int graffitiArtId { get; set; }

    [ProtoMember(2)]
    public CurrentLocation currentLocation { get; set; }

}