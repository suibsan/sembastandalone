
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonAcquireAreaItemRequest {
    [ProtoMember(1)]
    public required int dungeonDifficultyId { get; set; }

    [ProtoMember(2)]
    public required int entityId { get; set; }

}