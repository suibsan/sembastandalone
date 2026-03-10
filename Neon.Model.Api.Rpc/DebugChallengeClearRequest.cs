
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DebugChallengeClearRequest {
    [ProtoMember(1)]
    public int challengeId { get; set; }

}