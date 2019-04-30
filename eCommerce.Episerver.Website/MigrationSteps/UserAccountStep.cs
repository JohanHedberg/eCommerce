using EPiServer.Commerce.Internal.Migration.Steps;
using Mediachase.Commerce.Shared;

namespace eCommerce.Episerver.Website.MigrationSteps
{
    public class UserAccountStep : IMigrationStep
    {
        public int Order => 1;

        public string Name => "Create admin account";

        public string Description => "Creates the initial user account having admin priviliges.";

        public bool Execute(IProgressMessenger progressMessenger)
        {
            return true;
        }
    }
}