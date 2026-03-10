
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Rewards {
    [ProtoMember(1)]
    public required int type { get; set; }

    [ProtoMember(2)]
    public required Reward[] contents { get; set; }

}