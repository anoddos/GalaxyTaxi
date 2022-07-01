using ProtoBuf;

namespace GalaxyTaxi.Shared.Api.Models.Register;

[ProtoContract]
[Serializable]
public class ValidateEmail
{
    [ProtoMember(1)]
    public string CompanyEmail { get; set; } = null!;
}