
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbCommand {
    [ProtoMember(1)]
    public int commandId { get; set; }

    [ProtoMember(2)]
    public int xbCharacterWordsId { get; set; }

    [ProtoMember(5)]
    public bool isLockingCommand { get; set; }

    [ProtoMember(4)]
    public XbCommandCorrectType correctType { get; set; }

    [ProtoMember(3)]
    public int predictedScore { get; set; }

    [ProtoMember(8)]
    public int? battedBallPredictionId { get; set; }

    [ProtoMember(7)]
    public int[] predictedUseSkillOrbIds { get; set; }

}