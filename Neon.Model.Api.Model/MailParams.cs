
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MailParams {
    [ProtoMember(1)]
    public required int? mailTemplateId { get; set; }

    [ProtoMember(2)]
    public required string subject { get; set; }

    [ProtoMember(3)]
    public required string body { get; set; }

    [ProtoMember(4)]
    public required int? bulkMailId { get; set; }

    [ProtoMember(5)]
    public required string sender { get; set; }

}