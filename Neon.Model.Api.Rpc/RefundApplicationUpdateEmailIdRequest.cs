
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationUpdateEmailIdRequest {
    [ProtoMember(1)]
    public string emailId { get; set; }

}