
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbClientStatus {
    [ProtoMember(1)]
    public bool? previousAtBatIsOut { get; set; }

    [ProtoMember(2)]
    public bool? previousAtBatIsChance { get; set; }

    [ProtoMember(3)]
    public bool? currentAtBatIsChance { get; set; }

}