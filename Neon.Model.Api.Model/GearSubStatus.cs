
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GearSubStatus {
    [ProtoMember(3)]
    public int[] gearStatusRateSetIds { get; set; }

}