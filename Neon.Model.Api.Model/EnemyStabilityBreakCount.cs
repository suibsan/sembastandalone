
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class EnemyStabilityBreakCount {
    [ProtoMember(1)]
    public required int enemyId { get; set; }

    [ProtoMember(2)]
    public required int count { get; set; }

}