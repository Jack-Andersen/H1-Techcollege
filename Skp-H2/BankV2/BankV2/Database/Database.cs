using BankV2;
using BankV2.Shop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class Database
{
    #region Database_Connection...
    static SqlConnection connection;

    public static bool db_connection()
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "JACK-ANDERSEN-J";
        builder.InitialCatalog = "Bank-SkpH2";
        builder.IntegratedSecurity = true;

        connection = new SqlConnection(builder.ToString());
        try
        {
            connection.Open();
            return true;
        }
        catch
        {
            return false;
        }
    }
    #endregion

    //Bank

    #region LoginToUser...
    public static bool LoginToUser(string firstName, string password)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT * FROM [User] WHERE FirstName = @FirstName AND [Password] = @Password", connection);

        command.Parameters.AddWithValue("@FirstName", firstName);
        command.Parameters.AddWithValue("@Password", password);

        var result = command.ExecuteScalar();

        if (result != null ? (int)result > 0 : false)
        {
            return true;
        }
        else
            return false;
    }
    #endregion

    #region NewUser...
    public static void NewUser(User userBuffer)
    {
        using SqlCommand command = new SqlCommand(@"
            INSERT INTO [User] (FirstName, LastName, Age, Mail, Phonenumber, Password)
            VALUES(@FirstName, @LastName, @Age, @Mail, @Phonenumber, @Password)", connection);
        {
            command.Parameters.AddWithValue("@FirstName", userBuffer.FirstName);
            command.Parameters.AddWithValue("@LastName", userBuffer.LastName);
            command.Parameters.AddWithValue("@Age", userBuffer.Age);
            command.Parameters.AddWithValue("@Mail", userBuffer.Mail);
            command.Parameters.AddWithValue("@PhoneNumber", userBuffer.PhoneNumber);
            command.Parameters.AddWithValue("@Password", userBuffer.Password);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region GetMail...
    public static bool GetMail(string mail)
    {
        using SqlCommand command = new SqlCommand(@"
            SELECT Mail FROM [User] WHERE Mail = @Mail", connection);
        {
            command.Parameters.AddWithValue("@Mail", mail);

            var result = command.ExecuteScalar();

            if (result != null ? (int)result > 0 : false)
            {
                return true;
            }
            else
                return false;
        }
    }
    #endregion

    #region Password...
    public static void Password(string password, int id)
    {
        using SqlCommand command = new SqlCommand(@"
            UPDATE [User] SET [Password] = @Password WHERE Id = @Id", connection);
        {
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region
    public static void NewBalance(decimal balance, int id)
    {
        using SqlCommand command = new SqlCommand(@"
            INSERT INTO TransactionBalance (TransactionBalance, PersonId)
            VALUES (@Balance, @PersonId)", connection);
        {
            command.Parameters.AddWithValue("@Balance", balance);
            command.Parameters.AddWithValue("@PersonId", id);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region SetListTransactions...
    public static void SetListTransactions(Transaction transactionBuffer, int id)
    {
        using SqlCommand command = new SqlCommand(@"
            INSERT INTO [Transaction] (Amount, Note, [Date], [Transaction].PersonId)
            VALUES(@Amount, @Note, @Date, @Id)", connection);
        {
            command.Parameters.AddWithValue("@Amount", transactionBuffer.Amount);
            command.Parameters.AddWithValue("@Note", transactionBuffer.Note);
            command.Parameters.AddWithValue("@Date", transactionBuffer.Date);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region GetListTransactions...
    public static List<Transaction> GetListTransactions(int id)
    {
        List<Transaction> transactionList = new List<Transaction>();

        using SqlCommand command = new SqlCommand(@"
            SELECT Amount, Note, [Date], TransactionBalance.TransactionBalance FROM [Transaction]
            INNER JOIN TransactionBalance ON [Transaction].Id = TransactionBalance.Id
            INNER JOIN [User] ON [Transaction].PersonId = [User].Id WHERE[User].Id = @Id
            ORDER BY [Date] DESC, TransactionBalance.TransactionBalance ASC", connection);
        {
            command.Parameters.AddWithValue("@Id", id);

            SqlDataReader dataReader = command.ExecuteReader();
            {
                while (dataReader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.Amount = dataReader.GetInt32(0);
                    transaction.Note = dataReader.GetString(1);
                    transaction.Date = dataReader.GetDateTime(2);
                    transaction.Bank_Account.Balance = dataReader.GetDecimal(3);

                    transactionList.Add(transaction);
                }
                dataReader.Close();
                return transactionList;
            }
        }
    }
    #endregion

    #region AboutMeInfo...
    public static void AboutMeInfo(int id)
    {
        using SqlCommand command = new SqlCommand(@"
            SELECT FirstName, LastName, Age, Mail, PhoneNumber, [Password] FROM [User] WHERE Id = @id", connection);
        {
            command.Parameters.AddWithValue("@Id", id);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                AboutMePage.userBuffer.FirstName = dataReader.GetValue(0).ToString();
                AboutMePage.userBuffer.LastName = dataReader.GetValue(1).ToString();
                AboutMePage.userBuffer.Age = Convert.ToInt32(dataReader.GetValue(2));
                AboutMePage.userBuffer.Mail = dataReader.GetValue(3).ToString();
                AboutMePage.userBuffer.PhoneNumber = Convert.ToInt32(dataReader.GetValue(4));
                AboutMePage.password = dataReader.GetValue(5).ToString();
            }
            dataReader.Close();
        }
    }
    #endregion

    #region AboutMeUpdate...
    public static void AboutMeUpdate(User userBuffer, string password, int id)
    {
        using SqlCommand command = new SqlCommand(@"
            UPDATE [User] SET FirstName = @FirstName, LastName = @LastName, Age = @Age,
            Mail = @Mail, Phonenumber = @Phonenumber, [Password] = @Password WHERE Id = @Id", connection);
        {
            command.Parameters.AddWithValue("@FirstName", userBuffer.FirstName);
            command.Parameters.AddWithValue("@LastName", userBuffer.LastName);
            command.Parameters.AddWithValue("@Age", userBuffer.Age);
            command.Parameters.AddWithValue("@Mail", userBuffer.Mail);
            command.Parameters.AddWithValue("@PhoneNumber", userBuffer.PhoneNumber);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region UserId...
    public static int UserId(string firstName, string password)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT Id FROM [User] WHERE FirstName = @FirstName AND [Password] = Password", connection);

        command.Parameters.AddWithValue("@FirstName", firstName);
        command.Parameters.AddWithValue("@Password", password);

        int Id = (int)command.ExecuteScalar();

        return Id;
    }
    #endregion

    #region UserId...
    public static int UserIdMail(string mail)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT Id FROM [User] WHERE Mail = @Mail", connection);

        command.Parameters.AddWithValue("@Mail", mail);

        int Id = (int)command.ExecuteScalar();

        return Id;
    }
    #endregion

    #region UserIdPhone...
    public static int UserIdPhone(int phoneNumber)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT Id FROM [User] WHERE PhoneNumber = @PhoneNumber", connection);

        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

        int Id = (int)command.ExecuteScalar();

        return Id;
    }
    #endregion

    #region GetBalanceId...
    public static int GetBalanceId(int id)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT [User].Id, Balance From [User] INNER JOIN Balance ON [User].Id = Balance.Id WHERE PersonId = @Id", connection);

        command.Parameters.AddWithValue("@Id", id);

        int Id = (int)command.ExecuteScalar();

        return Id;
    }
    #endregion

    #region GetBalance...
    public static decimal GetBalance(int id)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT Balance.Balance From Balance WHERE Id = @Id", connection);

        command.Parameters.AddWithValue("@Id", id);

        decimal balance = (decimal)command.ExecuteScalar();

        return balance;
    }
    #endregion

    #region GetBalance...
    public static decimal GetReceiverBalance(int phoneNumber)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT Balance From Balance
        INNER JOIN [User] ON Balance.Id = [User].Id Where PhoneNumber = @PhoneNumber", connection);

        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

        decimal balance = (decimal)command.ExecuteScalar();

        return balance;
    }
    #endregion

    #region UpdateBalance...
    public static void UpdateBalance(decimal balance, int id)
    {
        SqlCommand command = new SqlCommand(@"
        Update Balance SET Balance = @balance WHERE PersonId = @Id".Replace(", ", "."), connection);

        command.Parameters.AddWithValue("@balance", balance);
        command.Parameters.AddWithValue("@Id", id);

        command.ExecuteNonQuery();
    }
    #endregion

    #region IdTotal...
    public static int IdTotal(int id)
    {
        SqlCommand command = new SqlCommand(@"
        SELECT COUNT (Id) FROM [Transaction] WHERE PersonId = @Id", connection);

        command.Parameters.AddWithValue("@Id", id);

        int? IdTotal = (int?)command.ExecuteScalar();

        if (IdTotal != null)
        {
            return (int)IdTotal;
        }
        else
            return 0;
    }
    #endregion

    #region TruncateTable...
    public static void TruncateTable(string name)
    {
        SqlCommand command = new SqlCommand(@"
        TRUNCATE TABLE " + name + "" , connection);

        command.ExecuteNonQuery();
    }
    #endregion

    #region TruncateTable...
    public static void DeleteTable(string name, int id)
    {
        SqlCommand command = new SqlCommand(@"
        DELETE FROM " + name + " WHERE PersonId = @Id", connection);

        command.Parameters.AddWithValue("@Id", id);

        command.ExecuteNonQuery();
    }
    #endregion

    #region TransferMoney...
    public static void TransferMoney(decimal balance, int phoneNumber)
    {
        SqlCommand command = new SqlCommand(@"
        Update Balance Set Balance = @Balance FROM Balance
        INNER JOIN [User] ON Balance.Id = [User].Id Where PhoneNumber = PhoneNumber", connection);

        command.Parameters.AddWithValue("@Balance", balance);
        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

        command.ExecuteNonQuery();
    }
    #endregion

    //Shop

    #region InsertItem...
    public static void InsertItem(Shop shopBuffer, int id)
    {
        using SqlCommand command = new SqlCommand(@"
            INSERT INTO Shop (Apple, Bread, Dount, Cost, [Transaction].PersonId)
            VALUES(@Apple, @Bread, @Dount, @Cost, @PersonId)", connection);
        {
            command.Parameters.AddWithValue("@Apple", shopBuffer.Apple);
            command.Parameters.AddWithValue("@Bread", shopBuffer.Bread);
            command.Parameters.AddWithValue("@Dount", shopBuffer.Dount);
            command.Parameters.AddWithValue("@Cost", shopBuffer.Cost);
            command.Parameters.AddWithValue("@PersonId", id);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region UpdateItem...
    public static void UpdateItem(Shop shopBuffer, int id)
    {
        using SqlCommand command = new SqlCommand(@"
            UPDATE Shop SET Apple = @Apple, Bread = @Bread, Dount = @Dount, Cost = @Cost WHERE PersonId = @PersonId", connection);
        {
            command.Parameters.AddWithValue("@Apple", shopBuffer.Apple);
            command.Parameters.AddWithValue("@Bread", shopBuffer.Bread);
            command.Parameters.AddWithValue("@Dount", shopBuffer.Dount);
            command.Parameters.AddWithValue("@Cost", shopBuffer.Cost);
            command.Parameters.AddWithValue("PersonId", id);

            command.ExecuteNonQuery();
        }
    }
    #endregion

    #region GetListTransactions...
    public static List<Shop> SelectItem(int id)
    {
        List<Shop> shopList = new List<Shop>();

        using SqlCommand command = new SqlCommand(@"
            SELECT TOP 1 Apple, Bread, Dount, Cost FROM Shop
            INNER JOIN [User] ON Shop.PersonId = [User].Id WHERE [User].Id = @PersonId 
            ORDER BY Cost DESC ", connection);
        {
            command.Parameters.AddWithValue("@PersonId", id);

            SqlDataReader dataReader = command.ExecuteReader();
            {
                while (dataReader.Read())
                {
                    Shop shop = new Shop();
                    shop.Apple = (int)dataReader.GetDecimal(0);
                    shop.Bread = (int)dataReader.GetDecimal(1);
                    shop.Dount = (int)dataReader.GetDecimal(2);
                    shop.Cost = dataReader.GetDecimal(3);

                    shopList.Add(shop);
                }
                dataReader.Close();
                return shopList;
            }
        }
    }
    #endregion

    #region DoesExists
    public static bool DeosExists(int id)
    {
        using SqlCommand command = new SqlCommand(@"
        SELECT TOP 1 PersonId FROM Shop WHERE PersonId = @PersonId", connection);

        command.Parameters.AddWithValue("@PersonId", id);

        var result = command.ExecuteScalar();

        if (result != null ? (int)result > 0 : false)
        {
            return true;
        }
        else
            return false;
    }
    #endregion

    //Inventory

    public static void SelectInventory(int id)
    {
        using SqlCommand command = new SqlCommand(@"
        SELECT Apple, Bread, Dount FROM Inventory WHERE PersonId = @PersonId", connection);

        command.Parameters.AddWithValue("@PersonId", id);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            MyShoppingList.InventoryBuffer.Apple = Convert.ToInt32(dataReader.GetValue(0));
            MyShoppingList.InventoryBuffer.Bread = Convert.ToInt32(dataReader.GetValue(1));
            MyShoppingList.InventoryBuffer.Dount = Convert.ToInt32(dataReader.GetValue(2));
        }
        dataReader.Close();
    }

    public static void UpdateInventory(List<Inventory> inventori, int id)
    {
        using SqlCommand command = new SqlCommand(@"
        UPDATE Inventory SET Apple = @Apple, Bread = @Bread, Dount = @Dount WHERE PersonId = @PersonId", connection);

        foreach (Inventory item in inventori)
        {
            command.Parameters.AddWithValue("@Apple", item.Apple);
            command.Parameters.AddWithValue("@Bread", item.Bread);
            command.Parameters.AddWithValue("@Dount", item.Dount);
            command.Parameters.AddWithValue("PersonId", id);

            command.ExecuteNonQuery();
        }
    }
}
