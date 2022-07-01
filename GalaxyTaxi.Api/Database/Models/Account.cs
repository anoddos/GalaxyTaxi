using GalaxyTaxi.Shared.Api.Models.Common;

namespace GalaxyTaxi.Api.Database.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public AccountType AccountType { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string PasswordHash { get; set; }

        public Account(Guid id, AccountType accountType, string email, string companyName, string passwordHash)
        {
            Id = id;
            Email = email;
            CompanyName = companyName;
            AccountType = accountType;
            PasswordHash = passwordHash;
        }
    }
}