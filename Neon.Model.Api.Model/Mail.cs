
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Mail {
    [ProtoMember(1)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int mailType { get; set; }

    [ProtoMember(3)]
    public MailParams mailParams { get; set; }

    [ProtoMember(4)]
    public Resource[] rewards { get; set; }

    [ProtoMember(5)]
    public DateTime? createdAt { get; set; }

    [ProtoMember(6)]
    public DateTime? openedAt { get; set; }

    [ProtoMember(7)]
    public DateTime? endAt { get; set; }

}