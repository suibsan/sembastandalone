
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpFormation {
    [ProtoMember(1)]
    public required XbMember[] members { get; set; }

    [ProtoMember(2)]
    public required int trainingScore { get; set; }

}