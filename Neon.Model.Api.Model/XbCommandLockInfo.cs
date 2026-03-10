
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbCommandLockInfo {
    [ProtoMember(1)]
    public int commandId { get; set; }

    [ProtoMember(2)]
    public int commandLockId { get; set; }

    [ProtoMember(3)]
    public XbCommandLockItemInfo[] lockItemInfos { get; set; }

    [ProtoMember(5)]
    public int unlockMagicOrbId { get; set; }

}