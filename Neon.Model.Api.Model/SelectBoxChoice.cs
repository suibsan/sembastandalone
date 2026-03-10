
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SelectBoxChoice {
    [ProtoMember(1)]
    public int itemId { get; set; }

    [ProtoMember(2)]
    public int number { get; set; }

}