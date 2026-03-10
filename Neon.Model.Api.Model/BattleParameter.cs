
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleParameter {
    [ProtoMember(1)]
    public required int id { get; set; }

    [ProtoMember(7)]
    public required Enemy[] enemies { get; set; }

}