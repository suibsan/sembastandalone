
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbCommandLockInfo {
    [ProtoMember(1)]
    public required int commandId { get; set; }

    [ProtoMember(2)]
    public required int commandLockId { get; set; }

    [ProtoMember(3)]
    public required XbCommandLockItemInfo[] lockItemInfos { get; set; }

    [ProtoMember(5)]
    public required int unlockMagicOrbId { get; set; }

}