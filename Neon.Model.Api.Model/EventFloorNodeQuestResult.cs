
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class EventFloorNodeQuestResult {
    [ProtoMember(1)]
    public required int score { get; set; }

}