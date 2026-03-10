
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MailListResponse {
    [ProtoMember(1)]
    public MailList list { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

}