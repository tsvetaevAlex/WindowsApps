namespace Budgethelper.Services
{
    internal static class AuthService
    {
        public static bool IsAuthorized { get; private set; }
        public static string UserName { get; private set; }

        public static void Authorize(int userId, string userName)
        {
            IsAuthorized = true;
            UserName = userName;
        }
    }
}