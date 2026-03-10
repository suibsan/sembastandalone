
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MailList {
    [ProtoMember(1)]
    public Mail[] unopened { get; set; }

    [ProtoMember(2)]
    public Mail[] opened { get; set; }

    [ProtoMember(3)]
    public BulkMail[] bulkMails { get; set; }

}