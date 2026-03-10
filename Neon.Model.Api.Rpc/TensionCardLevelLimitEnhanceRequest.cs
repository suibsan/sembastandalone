
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TensionCardLevelLimitEnhanceRequest {
    [ProtoMember(2)]
    public required int entityId { get; set; }

}