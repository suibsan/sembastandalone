
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundDestinationOverseaBank {
    [ProtoMember(1)]
    public string bankName { get; set; }

    [ProtoMember(2)]
    public string swiftCode { get; set; }

    [ProtoMember(3)]
    public string bankAccountNumber { get; set; }

    [ProtoMember(4)]
    public string bankAddress { get; set; }

    [ProtoMember(5)]
    public string bankAccountHolder { get; set; }

    [ProtoMember(6)]
    public string bankAccountOwnerCountry { get; set; }

    [ProtoMember(7)]
    public string bankAccountOwnerAddress { get; set; }

}