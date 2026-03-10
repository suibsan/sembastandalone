
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseUpdate {
    [ProtoMember(4)]
    public FractalViseArea changedFractalViseArea { get; set; }

    [ProtoMember(3)]
    public int[] enemyScores { get; set; }

    [ProtoMember(1)]
    public FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(2)]
    public FractalViseMission[] fractalViseMissions { get; set; }

}