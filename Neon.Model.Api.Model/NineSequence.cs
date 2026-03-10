
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class NineSequence {
    [ProtoMember(1)]
    public int nineSequenceId { get; set; }

    [ProtoMember(2)]
    public string choices { get; set; }

    [ProtoMember(3)]
    public DateTime? expiresAt { get; set; }

    [ProtoMember(4)]
    public DateTime? lastReceiveAt { get; set; }

    [ProtoMember(5)]
    public DateTime? lastReadAt { get; set; }

}