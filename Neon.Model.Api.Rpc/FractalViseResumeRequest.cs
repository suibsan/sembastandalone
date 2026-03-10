
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseResumeRequest {
    [ProtoMember(1)]
    public required int fractalViseId { get; set; }

}