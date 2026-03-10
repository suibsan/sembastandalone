
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Rewards {
    [ProtoMember(1)]
    public int type { get; set; }

    [ProtoMember(2)]
    public Reward[] contents { get; set; }

}