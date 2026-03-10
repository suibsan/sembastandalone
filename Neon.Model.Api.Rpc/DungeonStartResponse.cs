
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonStartResponse {
    [ProtoMember(1)]
    public required DungeonState dungeonState { get; set; }

    [ProtoMember(2)]
    public required DungeonEnemy[] dungeonEnemies { get; set; }

    [ProtoMember(4)]
    public required DungeonAreaItem[] dungeonAreaItems { get; set; }

    [ProtoMember(3)]
    public required Resources changedResources { get; set; }

}