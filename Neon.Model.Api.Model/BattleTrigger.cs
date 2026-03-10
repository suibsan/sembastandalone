
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleTrigger {
    [ProtoMember(1)]
    public required BattleTriggerType triggerType { get; set; }

    [ProtoMember(2)]
    public required int[] triggerIds { get; set; }

}