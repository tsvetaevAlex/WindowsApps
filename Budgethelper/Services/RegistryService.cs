namespace Budgethelper.Services
{
    /// <summary>
    /// mocked class for dev time   
    /// </summary>

    internal class RegistryService
    {
        public bool CheckPassword(string password)
        {
            return password == "1234";
        }
    }

}
