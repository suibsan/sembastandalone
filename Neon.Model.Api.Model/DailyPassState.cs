
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DailyPassState {
    [ProtoMember(1)]
    public int dailyPassId { get; set; }

    [ProtoMember(2)]
    public DateTime? expiresAt { get; set; }

    [ProtoMember(3)]
    public DateTime? lastReceivedAt { get; set; }

}