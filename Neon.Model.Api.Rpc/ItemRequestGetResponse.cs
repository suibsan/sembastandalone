
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequestGetResponse {
    [ProtoMember(1)]
    public required ItemRequest itemRequest { get; set; }

    [ProtoMember(2)]
    public required bool isPublished { get; set; }

}