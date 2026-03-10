
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequestGetResponse {
    [ProtoMember(1)]
    public ItemRequest itemRequest { get; set; }

    [ProtoMember(2)]
    public bool isPublished { get; set; }

}