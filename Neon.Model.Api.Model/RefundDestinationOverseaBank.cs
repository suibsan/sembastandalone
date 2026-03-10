
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundDestinationOverseaBank {
    [ProtoMember(1)]
    public required string bankName { get; set; }

    [ProtoMember(2)]
    public required string swiftCode { get; set; }

    [ProtoMember(3)]
    public required string bankAccountNumber { get; set; }

    [ProtoMember(4)]
    public required string bankAddress { get; set; }

    [ProtoMember(5)]
    public required string bankAccountHolder { get; set; }

    [ProtoMember(6)]
    public required string bankAccountOwnerCountry { get; set; }

    [ProtoMember(7)]
    public required string bankAccountOwnerAddress { get; set; }

}