namespace Budgethelper.Models
{
    public enum FundsSource_Type
    {
        Cash,
        Card,
    }

    public static class FundsSourceTypeExtensions
    {
        // Убрали override, изменили имя метода на ToFriendlyString
        public static string ToFriendlyString(this FundsSource_Type type)
        {
            switch (type)
            {
                case FundsSource_Type.Cash:
                    return "Наличные";
                case FundsSource_Type.Card:
                    return "Банковская карта";
                default:
                    return "Наличные";
            }
        }
    }
}
