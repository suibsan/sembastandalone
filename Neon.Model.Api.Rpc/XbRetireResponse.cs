
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbRetireResponse {
    [ProtoMember(1)]
    public XbPvpRankState rankMatchRankState { get; set; }

}