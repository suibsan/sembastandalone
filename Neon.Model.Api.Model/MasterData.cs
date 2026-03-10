
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MasterData {
    [ProtoMember(2)]
    public ShopProduct[] shopProducts { get; set; }

}