
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaBehavior {
    [ProtoMember(1)]
    public int actionSequenceId { get; set; }

}