
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class NewsNotification {
    [ProtoMember(1)]
    public DateTime? updatedAt { get; set; }

    [ProtoMember(2)]
    public DateTime? importantUpdatedAt { get; set; }

}