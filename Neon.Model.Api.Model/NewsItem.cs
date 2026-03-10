
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class NewsItem {
    [ProtoMember(1)]
    public required int newsGroupId { get; set; }

    [ProtoMember(2)]
    public required int priority { get; set; }

    [ProtoMember(3)]
    public required int category { get; set; }

    [ProtoMember(4)]
    public required string title { get; set; }

    [ProtoMember(5)]
    public required DateTime? startAt { get; set; }

    [ProtoMember(6)]
    public required DateTime? editedAt { get; set; }

    [ProtoMember(7)]
    public required bool isImportant { get; set; }

}