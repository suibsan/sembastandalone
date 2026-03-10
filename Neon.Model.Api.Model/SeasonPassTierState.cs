
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SeasonPassTierState {
    [ProtoMember(1)]
    public int seasonPassTierId { get; set; }

    [ProtoMember(2)]
    public DateTime? freePassRewardReceivedAt { get; set; }

    [ProtoMember(3)]
    public DateTime? paidPassRewardReceivedAt { get; set; }

}