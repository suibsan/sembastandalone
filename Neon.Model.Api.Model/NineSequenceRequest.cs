
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class NineSequenceRequest {
    [ProtoMember(1)]
    public required int id { get; set; }

    [ProtoMember(2)]
    public required string choices { get; set; }

}