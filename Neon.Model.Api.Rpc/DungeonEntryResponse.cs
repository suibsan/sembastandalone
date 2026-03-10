
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonEntryResponse {
    [ProtoMember(1)]
    public required int? currentDungeonDifficultyId { get; set; }

    [ProtoMember(2)]
    public required int? prevAccessDungeonDifficultyId { get; set; }

    [ProtoMember(3)]
    public required Resources changedResources { get; set; }

}