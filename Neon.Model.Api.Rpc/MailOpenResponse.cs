
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MailOpenResponse {
    [ProtoMember(1)]
    public Resources changedResources { get; set; }

    [ProtoMember(2)]
    public Reward[] rewards { get; set; }

    [ProtoMember(3)]
    public Resource[] overflowedRewards { get; set; }

    [ProtoMember(4)]
    public MailList list { get; set; }

}