
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DailyPassState {
    [ProtoMember(1)]
    public required int dailyPassId { get; set; }

    [ProtoMember(2)]
    public required DateTime? expiresAt { get; set; }

    [ProtoMember(3)]
    public required DateTime? lastReceivedAt { get; set; }

}