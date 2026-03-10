
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemOpenSelectBoxRequest {
    [ProtoMember(1)]
    public required SelectBoxChoice[] selectBoxChoices { get; set; }

}