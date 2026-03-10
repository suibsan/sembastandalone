
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaObject {
    [ProtoMember(1)]
    public int? areaObjectId { get; set; }

    [ProtoMember(2)]
    public int areaPointId { get; set; }

    [ProtoMember(3)]
    public int? areaObjectBehaviorId { get; set; }

    [ProtoMember(5)]
    public int? areaEnemyRateSetId { get; set; }

    [ProtoMember(6)]
    public AreaObjectAction action { get; set; }

}