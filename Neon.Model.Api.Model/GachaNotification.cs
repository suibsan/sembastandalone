
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaNotification {
    [ProtoMember(1)]
    public DateTime? latestGachaStartAt { get; set; }

    [ProtoMember(2)]
    public int[] executableGachaIds { get; set; }

}