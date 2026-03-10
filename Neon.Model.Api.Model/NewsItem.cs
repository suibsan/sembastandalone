
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class NewsItem {
    [ProtoMember(1)]
    public int newsGroupId { get; set; }

    [ProtoMember(2)]
    public int priority { get; set; }

    [ProtoMember(3)]
    public int category { get; set; }

    [ProtoMember(4)]
    public string title { get; set; }

    [ProtoMember(5)]
    public DateTime? startAt { get; set; }

    [ProtoMember(6)]
    public DateTime? editedAt { get; set; }

    [ProtoMember(7)]
    public bool isImportant { get; set; }

}