using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AddressBookSystem.Database;
using AddressBookSystem.Exceptions;
using Microsoft.Data.SqlClient;

namespace AddressBookSystem.Interface{
internal class AddressBookUtility : IAddressBook
{
    private readonly Dictionary<string, AddressBook> addressBooks =
        new Dictionary<string, AddressBook>(StringComparer.OrdinalIgnoreCase);

    public AddressBookUtility()
    {
        addressBooks["default"] = new AddressBook("default");
    }


public void AddContact()
{
    try
    {
        Console.Write("Address book name (blank = default): ");
        string bookName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(bookName))
            bookName = "default";

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstName))
            throw new AddressBookException("First name cannot be empty.");

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lastName))
            throw new AddressBookException("Last name cannot be empty.");

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State: ");
        string state = Console.ReadLine();

        Console.Write("ZipCode: ");
        string ZipCode = Console.ReadLine();

        Console.Write("PhoneNumber: ");
        string PhoneNumber = Console.ReadLine();
       
        Console.Write("Email: ");
        string email = Console.ReadLine();
       

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            // 🔎 Duplicate Check From Database
            string checkQuery = @"SELECT COUNT(*) FROM Contacts
                                  WHERE AddressBookName=@BookName
                                  AND FirstName=@FirstName
                                  AND LastName=@LastName";

            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@BookName", bookName);
            checkCmd.Parameters.AddWithValue("@FirstName", firstName);
            checkCmd.Parameters.AddWithValue("@LastName", lastName);

            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
                throw new AddressBookException("Contact already exists in database.");

            // ✅ Insert Query
            string insertQuery = @"INSERT INTO Contacts
                                   (AddressBookName, FirstName, LastName, City, State, ZipCode, PhoneNumber, Email)
                                   VALUES
                                   (@BookName, @FirstName, @LastName, @City, @State, @ZipCode, @PhoneNumber, @Email)";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@BookName", bookName);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@State", state);
            cmd.Parameters.AddWithValue("@ZipCode", ZipCode);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", email);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Contact added successfully to database!");
        }
    }
    catch (AddressBookException ex)
    {
        Console.WriteLine("Validation Error: " + ex.Message);
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

public void DisplayAllContacts()
{
    try
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = "SELECT * FROM Contacts ORDER BY AddressBookName, FirstName";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("No contacts found in database.");
                return;
            }

            while (reader.Read())
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Address Book: " + reader["AddressBookName"]);
                Console.WriteLine("First Name: " + reader["FirstName"]);
                Console.WriteLine("Last Name: " + reader["LastName"]);
                Console.WriteLine("City: " + reader["City"]);
                Console.WriteLine("State: " + reader["State"]);
                Console.WriteLine("Zip: " + reader["Zip"]);
                Console.WriteLine("Phone: " + reader["Phone"]);
                Console.WriteLine("Email: " + reader["Email"]);
            }

            reader.Close();
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

 public void EditExistingContact()
{
    try
    {
        Console.Write("Enter contact first name: ");
        string firstName = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            // 🔎 Check if contact exists
            string checkQuery = "SELECT * FROM Contacts WHERE FirstName = @FirstName";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@FirstName", firstName);

            SqlDataReader reader = checkCmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            reader.Read();
            int contactId = Convert.ToInt32(reader["Id"]);
            reader.Close();

            int choice = -1;

            do
            {
                Console.WriteLine("\nWhat do you want to edit?");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. City");
                Console.WriteLine("4. State");
                Console.WriteLine("5. Zip");
                Console.WriteLine("6. Phone");
                Console.WriteLine("7. Email");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                string column = "";
                string newValue = "";

                switch (choice)
                {
                    case 1:
                        column = "FirstName";
                        Console.Write("Enter new first name: ");
                        newValue = Console.ReadLine();
                        break;

                    case 2:
                        column = "LastName";
                        Console.Write("Enter new last name: ");
                        newValue = Console.ReadLine();
                        break;

                    case 3:
                        column = "City";
                        Console.Write("Enter new city: ");
                        newValue = Console.ReadLine();
                        break;

                    case 4:
                        column = "State";
                        Console.Write("Enter new state: ");
                        newValue = Console.ReadLine();
                        break;

                    case 5:
                        column = "Zip";
                        Console.Write("Enter new zip: ");
                        newValue = Console.ReadLine();
                       
                        break;

                    case 6:
                        column = "Phone";
                        Console.Write("Enter new phone: ");
                        newValue = Console.ReadLine();
                      
                        break;

                    case 7:
                        column = "Email";
                        Console.Write("Enter new email: ");
                        newValue = Console.ReadLine();
                       
                        break;

                    case 0:
                        Console.WriteLine("Exiting edit menu.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                if (choice != 0)
                {
                    string updateQuery = $"UPDATE Contacts SET {column} = @Value WHERE Id = @Id";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@Value", newValue);
                    updateCmd.Parameters.AddWithValue("@Id", contactId);

                    updateCmd.ExecuteNonQuery();

                    Console.WriteLine("Contact updated successfully in database.");
                }

            } while (choice != 0);
        }
    }
    catch (AddressBookException ex)
    {
        Console.WriteLine("Validation Error: " + ex.Message);
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

public void DeleteContact()
{
    try
    {
        Console.Write("Enter contact first name: ");
        string firstName = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            // 🔎 Check if contact exists
            string checkQuery = "SELECT Id FROM Contacts WHERE FirstName = @FirstName";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@FirstName", firstName);

            object result = checkCmd.ExecuteScalar();

            if (result == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            int contactId = Convert.ToInt32(result);

            // ✅ Delete Query
            string deleteQuery = "DELETE FROM Contacts WHERE Id = @Id";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
            deleteCmd.Parameters.AddWithValue("@Id", contactId);

            deleteCmd.ExecuteNonQuery();

            Console.WriteLine("Contact deleted successfully from database.");
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}
private void InsertSingleContact(SqlConnection con, SqlTransaction transaction)
{
    Console.Write("Address book name (blank = default): ");
    string bookName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(bookName))
        bookName = "default";

    Console.Write("First Name: ");
    string firstName = Console.ReadLine();

    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();

    Console.Write("City: ");
    string city = Console.ReadLine();

    Console.Write("State: ");
    string state = Console.ReadLine();

    Console.Write("Zip: ");
    string zip = Console.ReadLine();

    Console.Write("Phone: ");
    string phone = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    string insertQuery = @"INSERT INTO Contacts
                          (AddressBookName, FirstName, LastName, City, State, Zip, Phone, Email)
                          VALUES
                          (@BookName, @FirstName, @LastName, @City, @State, @Zip, @Phone, @Email)";

    SqlCommand cmd = new SqlCommand(insertQuery, con, transaction);

    cmd.Parameters.AddWithValue("@BookName", bookName);
    cmd.Parameters.AddWithValue("@FirstName", firstName);
    cmd.Parameters.AddWithValue("@LastName", lastName);
    cmd.Parameters.AddWithValue("@City", city);
    cmd.Parameters.AddWithValue("@State", state);
    cmd.Parameters.AddWithValue("@Zip", zip);
    cmd.Parameters.AddWithValue("@Phone", phone);
    cmd.Parameters.AddWithValue("@Email", email);

    cmd.ExecuteNonQuery();
}


public void AddMultipleContacts()
{
    try
    {
        Console.Write("How many contacts? ");

        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            throw new AddressBookException("Invalid number of contacts.");

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nEntering Contact {i + 1}");

                    // Reuse AddContact logic but without opening new connection
                    InsertSingleContact(con, transaction);
                }

                transaction.Commit();
                Console.WriteLine("All contacts added successfully.");
            }
            catch (Exception)
            {
                transaction.Rollback();
                Console.WriteLine("Error occurred. Transaction rolled back.");
                throw;
            }
        }
    }
    catch (AddressBookException ex)
    {
        Console.WriteLine("Validation Error: " + ex.Message);
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

    public void ListAllAddressBooks()
    {
        foreach (string name in addressBooks.Keys)
        {
            Console.WriteLine(name);
        }
    }

    public void CreateAddressBook()
    {
        try
        {
            Console.Write("New address book name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                throw new Exception("Address book already exists.");

            addressBooks[name] = new AddressBook(name);
            Console.WriteLine("Address book created.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

public void ListAllContactsInCityOrState()
{
    try
    {
        Console.Write("Enter City or State: ");
        string input = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string sqlQuery = @"SELECT * FROM Contacts
                                WHERE City = @Input OR State = @Input
                                ORDER BY FirstName";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Input", input);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("No contacts found for given city/state.");
                return;
            }

            while (reader.Read())
            {
                Console.WriteLine("\n-----------------------");
                Console.WriteLine("Address Book: " + reader["AddressBookName"]);
                Console.WriteLine("First Name: " + reader["FirstName"]);
                Console.WriteLine("Last Name: " + reader["LastName"]);
                Console.WriteLine("City: " + reader["City"]);
                Console.WriteLine("State: " + reader["State"]);
                Console.WriteLine("Phone: " + reader["Phone"]);
                Console.WriteLine("Email: " + reader["Email"]);
            }

            reader.Close();
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

  public void SearchContactInCityOrState()
{
    try
    {
        Console.Write("First Name: ");
        string name = Console.ReadLine();

        Console.Write("City/State: ");
        string input = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT * FROM Contacts
                             WHERE FirstName = @Name
                             AND (City = @Input OR State = @Input)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Input", input);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            while (reader.Read())
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("Address Book: " + reader["AddressBookName"]);
                Console.WriteLine("First Name: " + reader["FirstName"]);
                Console.WriteLine("Last Name: " + reader["LastName"]);
                Console.WriteLine("City: " + reader["City"]);
                Console.WriteLine("State: " + reader["State"]);
                Console.WriteLine("Phone: " + reader["Phone"]);
                Console.WriteLine("Email: " + reader["Email"]);
            }

            reader.Close();
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}
public void CountContactsByCityOrState()
{
    try
    {
        Console.Write("City or State: ");
        string input = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT COUNT(*) FROM Contacts
                             WHERE City = @Input OR State = @Input";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Input", input);

            con.Open();

            int count = (int)cmd.ExecuteScalar();

            Console.WriteLine($"Count: {count}");
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

public void SortContactsAlphabeticallyByFirstName()
{
    try
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT * FROM Contacts
                             ORDER BY FirstName ASC";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            while (reader.Read())
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("Address Book: " + reader["AddressBookName"]);
                Console.WriteLine("First Name: " + reader["FirstName"]);
                Console.WriteLine("Last Name: " + reader["LastName"]);
                Console.WriteLine("City: " + reader["City"]);
                Console.WriteLine("State: " + reader["State"]);
                Console.WriteLine("Phone: " + reader["Phone"]);
                Console.WriteLine("Email: " + reader["Email"]);
            }

            reader.Close();
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error: " + ex.Message);
    }
}

}}