
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserUpdateBirthdateRequest {
    [ProtoMember(1)]
    public required int year { get; set; }

    [ProtoMember(2)]
    public required int month { get; set; }

}