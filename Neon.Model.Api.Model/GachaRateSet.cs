
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaRateSet {
    [ProtoMember(1)]
    public int gachaRateSetId { get; set; }

    [ProtoMember(2)]
    public GachaRate[] rows { get; set; }

}