using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Budget_Tracking_App
{
    // Interface for ExpenseTracker
    public interface IExpenseTracker
    {
        void ShowRecentTransactions();
        void AddTransaction();
        void EditTransaction();
        void DeleteTransaction();
        void ShowCategories();
        void AddCategory();
        void SetBudgetForCategory();
        void ShowSpendingByCategories();
        void ShowOverallSpending();
    }
}