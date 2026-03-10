
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowInfo {
    [ProtoMember(1)]
    public int followUserNumber { get; set; }

}