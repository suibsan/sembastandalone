
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaReward {
    [ProtoMember(1)]
    public required int type { get; set; }

    [ProtoMember(2)]
    public required int id { get; set; }

    [ProtoMember(3)]
    public required Resource[] alternativeRewards { get; set; }

}