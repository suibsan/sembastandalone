
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GearSubStatus {
    [ProtoMember(3)]
    public required int[] gearStatusRateSetIds { get; set; }

}