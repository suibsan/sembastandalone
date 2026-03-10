
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleTaskTopic {
    [ProtoMember(1)]
    public BattleTaskTopicType type { get; set; }

    [ProtoMember(2)]
    public int count { get; set; }

}