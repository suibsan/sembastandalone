
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Mail {
    [ProtoMember(1)]
    public required int entityId { get; set; }

    [ProtoMember(2)]
    public required int mailType { get; set; }

    [ProtoMember(3)]
    public required MailParams mailParams { get; set; }

    [ProtoMember(4)]
    public required Resource[] rewards { get; set; }

    [ProtoMember(5)]
    public required DateTime? createdAt { get; set; }

    [ProtoMember(6)]
    public required DateTime? openedAt { get; set; }

    [ProtoMember(7)]
    public required DateTime? endAt { get; set; }

}