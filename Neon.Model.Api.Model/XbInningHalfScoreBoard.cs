
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbInningHalfScoreBoard {
    [ProtoMember(1)]
    public required bool isPlayer { get; set; }

    [ProtoMember(2)]
    public required string name { get; set; }

    [ProtoMember(3)]
    public required bool isTop { get; set; }

    [ProtoMember(4)]
    public required int totalScore { get; set; }

    [ProtoMember(5)]
    public required int hitCount { get; set; }

    [ProtoMember(6)]
    public required int errorCount { get; set; }

    [ProtoMember(7)]
    public required XbInningScore[] inningScores { get; set; }

}