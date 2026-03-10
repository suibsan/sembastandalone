
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbCommand {
    [ProtoMember(1)]
    public required int commandId { get; set; }

    [ProtoMember(2)]
    public required int xbCharacterWordsId { get; set; }

    [ProtoMember(5)]
    public required bool isLockingCommand { get; set; }

    [ProtoMember(4)]
    public required XbCommandCorrectType correctType { get; set; }

    [ProtoMember(3)]
    public required int predictedScore { get; set; }

    [ProtoMember(8)]
    public required int? battedBallPredictionId { get; set; }

    [ProtoMember(7)]
    public required int[] predictedUseSkillOrbIds { get; set; }

}