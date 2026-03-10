
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonEntryRequest {
    [ProtoMember(1)]
    public int dungeonId { get; set; }

    [ProtoMember(2)]
    public CurrentLocation currentLocation { get; set; }

}