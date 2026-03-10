
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ConsumedQuantifiedResource {
    [ProtoMember(1)]
    public int type { get; set; }

    [ProtoMember(2)]
    public int id { get; set; }

    [ProtoMember(3)]
    public int quantity { get; set; }

}