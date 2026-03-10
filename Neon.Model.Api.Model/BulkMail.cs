
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BulkMail {
    [ProtoMember(1)]
    public int id { get; set; }

    [ProtoMember(2)]
    public string subject { get; set; }

    [ProtoMember(3)]
    public string body { get; set; }

    [ProtoMember(4)]
    public string sender { get; set; }

}