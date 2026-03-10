
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRewardsTopRequest {
    [ProtoMember(1)]
    public required CurrentLocation currentLocation { get; set; }

}