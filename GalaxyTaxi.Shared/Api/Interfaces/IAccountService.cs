using GalaxyTaxi.Shared.Api.Models.Login;
using GalaxyTaxi.Shared.Api.Models.Register;
using ProtoBuf.Grpc.Configuration;

namespace GalaxyTaxi.Shared.Api.Interfaces;

[Service("Account")]
public interface IAccountService
{
    ValueTask RegisterAsync(RegisterRequest request);
    ValueTask ValidateEmailAsync(ValidateEmail request);
    ValueTask ValidateCompanyNameAsync(ValidateCompanyNameRequest request);

    ValueTask<LoginResponse> LoginAsync(LoginRequest request);
    ValueTask LogoutAsync();
}