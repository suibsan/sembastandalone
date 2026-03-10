
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseUpdate {
    [ProtoMember(4)]
    public required FractalViseArea changedFractalViseArea { get; set; }

    [ProtoMember(3)]
    public required int[] enemyScores { get; set; }

    [ProtoMember(1)]
    public required FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(2)]
    public required FractalViseMission[] fractalViseMissions { get; set; }

}