using ExpenseTracker.Models;

namespace ExpenseTracker.ViewModels
{
    public class ExpenseIndexViewModel
    {
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public decimal TotalAmount { get; set; }
    }
}
