
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbAddCommandUnlockItemResponse {
    [ProtoMember(2)]
    public required XbCommandLockInfo commandLockInfo { get; set; }

}