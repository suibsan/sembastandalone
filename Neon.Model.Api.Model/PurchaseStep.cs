
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseStep {
    [ProtoMember(4)]
    public int? storeProductId { get; set; }

    [ProtoMember(2)]
    public int? rewardSetId { get; set; }

    [ProtoMember(3)]
    public Resource[] costs { get; set; }

    [ProtoMember(5)]
    public string name { get; set; }

    [ProtoMember(6)]
    public string description { get; set; }

}