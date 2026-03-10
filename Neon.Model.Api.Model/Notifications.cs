
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Notifications {
    [ProtoMember(1)]
    public GachaNotification gacha { get; set; }

    [ProtoMember(2)]
    public bool? mail { get; set; }

    [ProtoMember(4)]
    public bool? itemRequest { get; set; }

}