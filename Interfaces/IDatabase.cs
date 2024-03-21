using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracking_App
{
    // Interface for the database
    public interface IDatabase
    {
        // Method to get the next transaction ID
        int GetNextTransactionId();

        // Method to add a transaction
        void AddTransaction(Transaction transaction);

        // Method to delete a transaction
        void DeleteTransaction(int id);

        // Method to add a category
        void AddCategory(string name, decimal budget);

        // Method to get all transactions
        List<Transaction> GetTransactions();

        // Method to get all categories
        List<Category> GetCategories();
    }
}