namespace Budgethelper.Models
{
    public enum Money_SourceType
    {
        Cash,
        Card
    }

    public class MoneySource
    {
        public Money_SourceType Type { get; set; }

        public override string ToString()
        {
            switch (Type)
            {
                case Money_SourceType.Cash:
                    return "Наличные";
                case Money_SourceType.Card:
                    return "Банковская карта";
                default:
                    return Type.ToString();
            }
        }
    }
}
