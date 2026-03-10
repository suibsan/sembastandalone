
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopRandomCostumeListResponse {
    [ProtoMember(1)]
    public int[] characterCostumeIds { get; set; }

    [ProtoMember(2)]
    public DateTime? expiresAt { get; set; }

}