
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ResourceEntities {
    [ProtoMember(4)]
    public long[] followUserIds { get; set; }

    [ProtoMember(1)]
    public int[] gearEntityIds { get; set; }

    [ProtoMember(3)]
    public int[] tensionCardEntityIds { get; set; }

}