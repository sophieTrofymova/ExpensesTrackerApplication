using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public enum CategoryType
    {
        Income,
        Expense
    }
    public class CategoryInfo
    {
        public static List<CategoryInfo> ExpenseCategories = new List<CategoryInfo>
        {
            new CategoryInfo("Food & Dining","food_icon.png" ),
            new CategoryInfo("Rent","rent_icon.png" ),
            new CategoryInfo("Transportation", "transport_icon.png" ),
            new CategoryInfo("Utilities", "utilities_icon.png" ),
            new CategoryInfo("Entertainment", "entertainment_icon.png" ),
            new CategoryInfo("Investment","investment_icon.png" ),
            new CategoryInfo("Healthcare", "health_icon.png" ),
            new CategoryInfo("Shopping", "shopping_icon.png" ),
            new CategoryInfo("Travel", "travel_icon.png" ),
            new CategoryInfo("Education","education_icon.png" ),
            new CategoryInfo("Gifts & Charity","charity_icon.png" ),
            new CategoryInfo("Transfer", "transfer_icon.png" )
        };
        public static List<CategoryInfo> IncomeCategories = new List<CategoryInfo>
        {
            new CategoryInfo("Salary", "salary-icon.png"),
            new CategoryInfo("Bonus", "bonus-icon.png" )
        };
        public string Description { get; set; }
        public string ImageIcon { get; set; }



        public CategoryInfo(string description, string imageIcon)
        {
            Description = description;
            ImageIcon = imageIcon;

        }



    }
}
