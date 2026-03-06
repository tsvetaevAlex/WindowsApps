using System.Collections.Generic;

namespace Budgethelper.Models
{
    /// <summary>
    /// Wallet class enhancement regarding to multi wallet logic
    /// </summary>

    public class Wallet
    {
        public string Owner { get; set; } // user Uid 
        public string Name { get; set; } // wallet name / to choose correct wallet in case of a few existing
        public static List<Money_Source> AccountsList { get; set; } = new List<Money_Source>(); // money source list related to current wallet
                                                                                      // (e.g.cash, debit card1, card2)
    }
}
