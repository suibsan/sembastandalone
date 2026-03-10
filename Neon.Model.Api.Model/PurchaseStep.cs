
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseStep {
    [ProtoMember(4)]
    public required int? storeProductId { get; set; }

    [ProtoMember(2)]
    public required int? rewardSetId { get; set; }

    [ProtoMember(3)]
    public required Resource[] costs { get; set; }

    [ProtoMember(5)]
    public required string name { get; set; }

    [ProtoMember(6)]
    public required string description { get; set; }

}