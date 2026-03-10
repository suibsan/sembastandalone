
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpFormationResponse {
    [ProtoMember(1)]
    public XbMember[] playerMembers { get; set; }

    [ProtoMember(2)]
    public XbMember[] allPlayerMembers { get; set; }

    [ProtoMember(3)]
    public bool isFormationInitialized { get; set; }

}