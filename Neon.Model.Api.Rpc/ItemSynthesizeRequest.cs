
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemSynthesizeRequest {
    [ProtoMember(1)]
    public int itemSynthesisId { get; set; }

    [ProtoMember(2)]
    public int count { get; set; }

    [ProtoMember(3)]
    public CurrentLocation currentLocation { get; set; }

}