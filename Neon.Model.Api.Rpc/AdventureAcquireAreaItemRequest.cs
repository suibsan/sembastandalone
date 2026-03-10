
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureAcquireAreaItemRequest {
    [ProtoMember(4)]
    public required int areaItemId { get; set; }

    [ProtoMember(3)]
    public required CurrentLocation currentLocation { get; set; }

}