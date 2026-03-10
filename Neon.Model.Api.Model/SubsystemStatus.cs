
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SubsystemStatus {
    [ProtoMember(1)]
    public DateTime? startAt { get; set; }

    [ProtoMember(2)]
    public string message { get; set; }

    [ProtoMember(3)]
    public string title { get; set; }

    [ProtoMember(4)]
    public bool hideTimes { get; set; }

}