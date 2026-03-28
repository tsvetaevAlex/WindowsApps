namespace Budgethelper.Models
{
    public enum FundsSource_Type
    {
        Cash,
        Card
    }

    public class MoneySource
    {
        public FundsSource_Type Type { get; set; }

        public override string ToString()
        {
            switch (Type)
            {
                case FundsSource_Type.Cash:
                    return "Наличные";
                case FundsSource_Type.Card:
                    return "Банковская карта";
                default:
                    return Type.ToString();
            }
        }
    }
}
