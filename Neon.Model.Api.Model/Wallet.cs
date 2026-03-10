
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Wallet {
    [ProtoMember(1)]
    public int free { get; set; }

    [ProtoMember(2)]
    public int paid { get; set; }

}