
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ResourceEntities {
    [ProtoMember(4)]
    public required long[] followUserIds { get; set; }

    [ProtoMember(1)]
    public required int[] gearEntityIds { get; set; }

    [ProtoMember(3)]
    public required int[] tensionCardEntityIds { get; set; }

}