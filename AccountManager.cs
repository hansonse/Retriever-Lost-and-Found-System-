using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public class AccountManager
    {
        

        public bool SignIn(string username, string password)
        {
            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    
                    string query =
                        "SELECT [username], [password] FROM [Users] " +
                        "WHERE [username] = ? AND [password] = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read()) return false;

                            string storedUsername = dr["username"]?.ToString() ?? "";
                            string storedPassword = dr["password"]?.ToString() ?? "";

                            bool usernameMatch = string.Equals(
                                storedUsername, username,
                                StringComparison.Ordinal);

                            bool passwordMatch = string.Equals(
                                storedPassword, password,
                                StringComparison.Ordinal);

                            return usernameMatch && passwordMatch;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }



        public string GetRole(string username)
        {
            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query =
                        "SELECT [role] FROM [Users] " +
                        "WHERE [username] = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error getting role: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return "";
            }
        }



        public bool VerifyAdminKey(string key,
                                   string secretPassword,
                                   out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(key))
            {
                errorMessage = "Access key cannot be empty.";
                return false;
            }

            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query =
                        "SELECT COUNT(*) FROM [AdminKeys] " +
                        "WHERE [accessKey] = ? " +
                        "AND [secretPassword] = ? " +
                        "AND [isActive] = True";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", key.Trim());
                        cmd.Parameters.AddWithValue("?",
                            secretPassword.Trim());

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Verification error: " + ex.Message;
                return false;
            }
        }



        public bool VerifyStudent(string studentID,
                                  string firstName,
                                  string middleName,
                                  string lastName,
                                  out string fullName,
                                  out string department,
                                  out string errorMessage)
        {
            fullName = "";
            department = "";
            errorMessage = "";

            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT [fullName], [department] FROM [SchoolRecords] " +
                        "WHERE [studentID] = ? AND " +
                        "      [firstName] = ? AND " +
                        "      [lastName]  = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", studentID.Trim());
                        cmd.Parameters.AddWithValue("?", firstName.Trim());
                        cmd.Parameters.AddWithValue("?", lastName.Trim());

                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                errorMessage =
                                    "No matching school record found. " +
                                    "Please check your details.";
                                return false;
                            }
                            fullName = dr["fullName"] != DBNull.Value
                                ? dr["fullName"].ToString() : "";
                            department = dr["department"] != DBNull.Value
                                ? dr["department"].ToString() : "";
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Verification error: " + ex.Message;
                return false;
            }
        }



        public bool VerifyEmployeeRecord(string firstName,
                                         string middleName,
                                         string lastName,
                                         string employeeID)
        {
            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT COUNT(*) FROM [EmployeeRecords] " +
                        "WHERE [employeeID] = ? AND " +
                        "      [firstName]  = ? AND " +
                        "      [lastName]   = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", employeeID.Trim());
                        cmd.Parameters.AddWithValue("?", firstName.Trim());
                        cmd.Parameters.AddWithValue("?", lastName.Trim());

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Employee verification error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }



        public bool Register(string username, string password,
                             string studentID, string fullName,
                             string department,
                             out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password cannot be empty.";
                return false;
            }

            if (password.Length < 6)
            {
                errorMessage = "Password must be at least 6 characters.";
                return false;
            }

            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkQuery =
                        "SELECT COUNT(*) FROM [Users] " +
                        "WHERE [username] = ?";

                    int exists;
                    using (OleDbCommand checkCmd =
                        new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", username);
                        exists = (int)checkCmd.ExecuteScalar();
                    }

                    if (exists > 0)
                    {
                        errorMessage =
                            "Username already exists. " +
                            "Please choose another.";
                        return false;
                    }

                    string insertQuery =
                        "INSERT INTO [Users] " +
                        "([username], [password], [role], [adminName]," +
                        " [studentID], [fullName], [department]) " +
                        "VALUES (?, ?, 'user', '', ?, ?, ?)";

                    using (OleDbCommand insertCmd =
                        new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("?", username);
                        insertCmd.Parameters.AddWithValue("?", password);
                        insertCmd.Parameters.AddWithValue("?", studentID);
                        insertCmd.Parameters.AddWithValue("?", fullName);
                        insertCmd.Parameters.AddWithValue("?",
                            department ?? "");
                        insertCmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Registration error: " + ex.Message;
                return false;
            }
        }



        public bool RegisterAdmin(string firstName,
                                  string middleName,
                                  string lastName,
                                  string employeeID,
                                  string department,
                                  string password,
                                  out string errorMessage,
                                  out string generatedUsername)
        {
            errorMessage = "";
            generatedUsername = "";

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                errorMessage =
                    "First and last name cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(employeeID))
            {
                errorMessage = "Employee ID cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(department))
            {
                errorMessage = "Department cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password cannot be empty.";
                return false;
            }

            if (password.Length < 6)
            {
                errorMessage =
                    "Password must be at least 6 characters.";
                return false;
            }

            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    
                    string dupCheck =
                        "SELECT COUNT(*) FROM [Users] " +
                        "WHERE [employeeID] = ?";

                    int alreadyExists;
                    using (OleDbCommand dupCmd =
                        new OleDbCommand(dupCheck, conn))
                    {
                        dupCmd.Parameters.AddWithValue("?",
                            employeeID.Trim());
                        alreadyExists = (int)dupCmd.ExecuteScalar();
                    }

                    if (alreadyExists > 0)
                    {
                        errorMessage =
                            "An account already exists for " +
                            "this Employee ID.";
                        return false;
                    }

                   
                    string countQuery =
                        "SELECT COUNT(*) FROM [Users] " +
                        "WHERE [role] = 'admin'";

                    int adminCount;
                    using (OleDbCommand countCmd =
                        new OleDbCommand(countQuery, conn))
                    {
                        adminCount = (int)countCmd.ExecuteScalar();
                    }

                    string year = DateTime.Now.Year.ToString();
                    string seq = (adminCount + 1).ToString("D3");
                    string username = "ADM-" + year + "-" + seq;

                    string fullName =
                        firstName.Trim() + " " +
                        (string.IsNullOrWhiteSpace(middleName)
                            ? "" : middleName.Trim() + " ") +
                        lastName.Trim();

                    string insertQuery =
                        "INSERT INTO [Users] " +
                        "([username], [password], [role], [adminName]," +
                        " [employeeID], [fullName], [department]) " +
                        "VALUES (?, ?, 'admin', ?, ?, ?, ?)";

                    using (OleDbCommand insertCmd =
                        new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("?", username);
                        insertCmd.Parameters.AddWithValue("?", password);
                        insertCmd.Parameters.AddWithValue("?", fullName);
                        insertCmd.Parameters.AddWithValue("?",
                            employeeID.Trim());
                        insertCmd.Parameters.AddWithValue("?", fullName);
                        insertCmd.Parameters.AddWithValue("?",
                            department.Trim());
                        insertCmd.ExecuteNonQuery();
                    }

                    generatedUsername = username;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Registration error: " + ex.Message;
                return false;
            }
        }



        public int GetUserID(string username)
        {
            try
            {
                using (OleDbConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query =
                        "SELECT [userID] FROM [Users] " +
                        "WHERE [username] = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error fetching user ID: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return 0;
        }
    }
}