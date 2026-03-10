
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbLibrettoInfo {
    [ProtoMember(1)]
    public required string sequencePath { get; set; }

}