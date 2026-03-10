
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Notifications {
    [ProtoMember(1)]
    public required GachaNotification gacha { get; set; }

    [ProtoMember(2)]
    public required bool? mail { get; set; }

    [ProtoMember(4)]
    public required bool? itemRequest { get; set; }

}