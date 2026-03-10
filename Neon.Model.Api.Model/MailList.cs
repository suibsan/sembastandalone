
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MailList {
    [ProtoMember(1)]
    public required Mail[] unopened { get; set; }

    [ProtoMember(2)]
    public required Mail[] opened { get; set; }

    [ProtoMember(3)]
    public required BulkMail[] bulkMails { get; set; }

}