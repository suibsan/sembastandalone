
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaItem {
    [ProtoMember(1)]
    public int areaItemId { get; set; }

    [ProtoMember(2)]
    public bool acquired { get; set; }

}