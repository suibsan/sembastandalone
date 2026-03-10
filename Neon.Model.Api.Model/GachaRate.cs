
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaRate {
    [ProtoMember(1)]
    public int gachaRateId { get; set; }

    [ProtoMember(4)]
    public string percentRate { get; set; }

    [ProtoMember(2)]
    public string percentRatePerCard { get; set; }

    [ProtoMember(3)]
    public GachaCard[] cards { get; set; }

}