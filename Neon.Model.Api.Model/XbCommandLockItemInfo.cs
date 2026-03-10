
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbCommandLockItemInfo {
    [ProtoMember(3)]
    public required int magicOrbId { get; set; }

    [ProtoMember(2)]
    public required int? status { get; set; }

}