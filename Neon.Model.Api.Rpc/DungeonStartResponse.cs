
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonStartResponse {
    [ProtoMember(1)]
    public DungeonState dungeonState { get; set; }

    [ProtoMember(2)]
    public DungeonEnemy[] dungeonEnemies { get; set; }

    [ProtoMember(4)]
    public DungeonAreaItem[] dungeonAreaItems { get; set; }

    [ProtoMember(3)]
    public Resources changedResources { get; set; }

}