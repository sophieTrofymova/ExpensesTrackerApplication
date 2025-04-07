using System.Globalization;

namespace ExpenseTracker {
    public static class Ext {
        public static string ToCurrencyString(this decimal amount, CurrencyType currency) {
            var culture = CultureInfo.InvariantCulture;

            switch (currency) {
                case CurrencyType.EUR:
                    culture = new CultureInfo("fr-FR");
                    break;
                case CurrencyType.GBP:
                    culture = new CultureInfo("en-GB");
                    break;
                case CurrencyType.USD:
                default:
                    culture = new CultureInfo("en-US");
                    break;
            }

            return string.Format(culture, "{0:C}", amount);
        }
    }
}
