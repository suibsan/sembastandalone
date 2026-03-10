
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AreaBgm {
    [ProtoMember(1)]
    public int id { get; set; }

    [ProtoMember(2)]
    public string eventName { get; set; }

}