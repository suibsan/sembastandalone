
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterCostumeUpdateRequest {
    [ProtoMember(2)]
    public required int characterCostumeId { get; set; }

}