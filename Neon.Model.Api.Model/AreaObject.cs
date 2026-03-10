
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaObject {
    [ProtoMember(1)]
    public required int? areaObjectId { get; set; }

    [ProtoMember(2)]
    public required int areaPointId { get; set; }

    [ProtoMember(3)]
    public required int? areaObjectBehaviorId { get; set; }

    [ProtoMember(5)]
    public required int? areaEnemyRateSetId { get; set; }

    [ProtoMember(6)]
    public required AreaObjectAction action { get; set; }

}