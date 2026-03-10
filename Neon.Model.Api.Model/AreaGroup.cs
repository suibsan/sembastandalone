
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaGroup {
    [ProtoMember(1)]
    public int areaGroupId { get; set; }

}