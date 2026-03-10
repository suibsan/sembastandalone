
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureUpdateCharacterStatusRequest {
    [ProtoMember(1)]
    public CharacterUpdate[] characterUpdates { get; set; }

}