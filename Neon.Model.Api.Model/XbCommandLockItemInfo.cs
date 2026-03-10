
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbCommandLockItemInfo {
    [ProtoMember(3)]
    public int magicOrbId { get; set; }

    [ProtoMember(2)]
    public int? status { get; set; }

}