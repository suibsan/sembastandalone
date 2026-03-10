
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbInningHalfScoreBoard {
    [ProtoMember(1)]
    public bool isPlayer { get; set; }

    [ProtoMember(2)]
    public string name { get; set; }

    [ProtoMember(3)]
    public bool isTop { get; set; }

    [ProtoMember(4)]
    public int totalScore { get; set; }

    [ProtoMember(5)]
    public int hitCount { get; set; }

    [ProtoMember(6)]
    public int errorCount { get; set; }

    [ProtoMember(7)]
    public XbInningScore[] inningScores { get; set; }

}