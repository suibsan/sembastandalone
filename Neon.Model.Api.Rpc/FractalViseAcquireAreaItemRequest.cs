
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseAcquireAreaItemRequest {
    [ProtoMember(1)]
    public required int fractalViseAreaId { get; set; }

    [ProtoMember(2)]
    public required int entityId { get; set; }

    [ProtoMember(3)]
    public required CurrentLocation currentLocation { get; set; }

}