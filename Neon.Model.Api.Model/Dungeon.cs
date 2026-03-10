
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Dungeon {
    [ProtoMember(1)]
    public int dungeonId { get; set; }

    [ProtoMember(2)]
    public bool isFinished { get; set; }

}