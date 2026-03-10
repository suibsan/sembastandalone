
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterLimitBreakRequest {
    [ProtoMember(1)]
    public required int characterId { get; set; }

    [ProtoMember(2)]
    public required int limitBreakCount { get; set; }

}