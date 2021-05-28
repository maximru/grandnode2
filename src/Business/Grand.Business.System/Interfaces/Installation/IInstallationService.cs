using System.Threading.Tasks;

namespace Grand.Business.System.Interfaces.Installation
{
    public partial interface IInstallationService
    {
        Task InstallData(string defaultUserEmail, string defaultUserPassword, string collation, bool skipCreateIndex = false, bool installSampleData = true, string companyName = "", string companyAddress = "", string companyPhoneNumber = "", string companyEmail = "");
    }
}
