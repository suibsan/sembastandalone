
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class QuestState {
    [ProtoMember(1)]
    public int questId { get; set; }

    [ProtoMember(2)]
    public int clearCount { get; set; }

    [ProtoMember(3)]
    public int bestScore { get; set; }

}