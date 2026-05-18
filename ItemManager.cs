using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{

    public class ItemManager
    {
       
        private static int SafeInt(OleDbDataReader dr, string col)
        {
            try { return Convert.ToInt32(dr[col]); }
            catch { return 0; }
        }

        
        private static Item ReadItem(OleDbDataReader dr)
        {
            return new Item(
                dr["itemID"].ToString(),
                dr["name"].ToString(),
                dr["description"].ToString(),
                dr["location"].ToString(),
                dr["locationSurrendered"] == DBNull.Value ? "" : dr["locationSurrendered"].ToString(),
                Convert.ToDateTime(dr["date"]),
                dr["status"].ToString(),
                dr["classification"].ToString(),
                dr["reporter"].ToString(),
                dr["imagePath"].ToString(),
                dr["visibility"].ToString(),
                SafeInt(dr, "userID")
            );
        }

        
        public bool ReportLostItem(string name,
                                   string description,
                                   string location,
                                   DateTime date,
                                   string category,
                                   string customCategory,
                                   string reporter,
                                   int userID,
                                   string imagePath,
                                   out string newItemID,
                                   out string errorMessage)
        {
            newItemID = "";
            errorMessage = "";

            string finalCategory = ClassifyItem(category, customCategory);

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    
                    const string query =
                        "INSERT INTO [Items] " +
                        "([name], [description], [location], " +
                        " [date], [status], [reporter], " +
                        " [classification], [imagePath], " +
                        " [visibility], [userID]) " +
                        "VALUES (?, ?, ?, ?, 'Lost', ?, ?, ?, 'Public', ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", name);
                        cmd.Parameters.AddWithValue("?", description);
                        cmd.Parameters.AddWithValue("?", location);

                        OleDbParameter dateParam = new OleDbParameter("?", OleDbType.Date);
                        dateParam.Value = date.Date;
                        cmd.Parameters.Add(dateParam);

                        cmd.Parameters.AddWithValue("?", reporter);
                        cmd.Parameters.AddWithValue("?", finalCategory);
                        cmd.Parameters.AddWithValue("?", DBNull.Value); 

                        OleDbParameter userParam = new OleDbParameter("?", OleDbType.Integer);
                        userParam.Value = userID;
                        cmd.Parameters.Add(userParam);

                        cmd.ExecuteNonQuery();
                    }

                    
                    using (OleDbCommand idCmd =
                        new OleDbCommand("SELECT @@IDENTITY", conn))
                    {
                        newItemID = idCmd.ExecuteScalar().ToString();
                    }

                    
                    string savedImagePath = CopyPhoto(
                        imagePath,
                        DatabaseHelper.ImagesFolder + @"lost\",
                        "LOST-" + newItemID);

                    
                    if (!string.IsNullOrEmpty(savedImagePath))
                    {
                        const string updateImg =
                            "UPDATE [Items] SET [imagePath] = ? " +
                            "WHERE [itemID] = ?";

                        using (OleDbCommand upd =
                            new OleDbCommand(updateImg, conn))
                        {
                            upd.Parameters.AddWithValue("?", savedImagePath);

                            OleDbParameter idParam =
                                new OleDbParameter("?", OleDbType.Integer);
                            idParam.Value = Convert.ToInt32(newItemID);
                            upd.Parameters.Add(idParam);

                            upd.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error reporting lost item: " + ex.Message;
                return false;
            }
        }

        

        public bool ReportFoundItem(string name,
                                    string description,
                                    string location,
                                    string locationSurrendered,
                                    DateTime date,
                                    string category,
                                    string customCategory,
                                    string reporter,
                                    int userID,
                                    string imagePath,
                                    out string newItemID,
                                    out string errorMessage)
        {
            newItemID = "";
            errorMessage = "";

            string finalCategory = ClassifyItem(category, customCategory);

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    
                    const string query =
                    "INSERT INTO [Items] " +
                    "([name], [description], [location], [locationSurrendered], " +
                    " [date], [status], [reporter], " +
                    " [classification], [imagePath], " +
                    " [visibility], [userID]) " +
                    "VALUES (?, ?, ?, ?, ?, 'Found', ?, ?, ?, 'Public', ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", name);
                        cmd.Parameters.AddWithValue("?", description);
                        cmd.Parameters.AddWithValue("?", location);
                        cmd.Parameters.AddWithValue("?", locationSurrendered);

                        OleDbParameter dateParam = new OleDbParameter("?", OleDbType.Date);
                        dateParam.Value = date.Date;
                        cmd.Parameters.Add(dateParam);

                        cmd.Parameters.AddWithValue("?", reporter);
                        cmd.Parameters.AddWithValue("?", finalCategory);
                        cmd.Parameters.AddWithValue("?", DBNull.Value);

                        OleDbParameter userParam = new OleDbParameter("?", OleDbType.Integer);
                        userParam.Value = userID;
                        cmd.Parameters.Add(userParam);

                        cmd.ExecuteNonQuery();
                    }

                    
                    using (OleDbCommand idCmd =
                        new OleDbCommand("SELECT @@IDENTITY", conn))
                    {
                        newItemID = idCmd.ExecuteScalar().ToString();
                    }

                    
                    string savedImagePath = CopyPhoto(
                        imagePath,
                        DatabaseHelper.ImagesFolder + @"found\",
                        "FOUND-" + newItemID);

                    
                    if (!string.IsNullOrEmpty(savedImagePath))
                    {
                        const string updateImg =
                            "UPDATE [Items] SET [imagePath] = ? " +
                            "WHERE [itemID] = ?";

                        using (OleDbCommand upd =
                            new OleDbCommand(updateImg, conn))
                        {
                            upd.Parameters.AddWithValue("?", savedImagePath);

                            OleDbParameter idParam =
                                new OleDbParameter("?", OleDbType.Integer);
                            idParam.Value = Convert.ToInt32(newItemID);
                            upd.Parameters.Add(idParam);

                            upd.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error reporting found item: " + ex.Message;
                return false;
            }
        }

        

        public List<Item> GetUserReports(string reporter, string type)
        {
            List<Item> items = new List<Item>();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "SELECT * FROM [Items] " +
                        "WHERE [reporter] = ? " +
                        "AND   [status]   = ? " +
                        "ORDER BY [date] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", reporter);
                        cmd.Parameters.AddWithValue("?", type);

                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                items.Add(ReadItem(dr));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }

       

        public List<Item> GetAllItems(bool adminView = false)
        {
            List<Item> items = new List<Item>();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = adminView
                        ? "SELECT * FROM [Items] WHERE [status] <> 'Archived' ORDER BY [date] DESC"
                        : "SELECT * FROM [Items] WHERE [status] = 'Lost' OR [status] = 'Found' ORDER BY [date] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            items.Add(ReadItem(dr));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }

        

        public List<Item> GetLostItemsForMatching()
            => GetItemsByStatus("Lost", "Error loading lost items");

        public List<Item> GetFoundItemsForMatching()
            => GetItemsByStatus("Found", "Error loading found items");

        

        public string ClassifyItem(string category,
                                   string customCategory = "")
        {
            if (string.Equals(category, "Other",
                    StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(customCategory))
            {
                return customCategory.Trim();
            }
            return category ?? "Uncategorized";
        }

        

        public bool CreateMatch(int lostItemID,
                                int foundItemID,
                                string matchedBy,
                                string remarks,
                                out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string checkQuery =
                        "SELECT COUNT(*) FROM [Matches] " +
                        "WHERE [lostItemID]  = ? " +
                        "AND   [foundItemID] = ? " +
                        "AND   [status]      = 'Pending'";

                    using (OleDbCommand checkCmd =
                        new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", lostItemID);
                        checkCmd.Parameters.AddWithValue("?", foundItemID);

                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            errorMessage =
                                "These two items are already matched " +
                                "and pending confirmation.";
                            return false;
                        }
                    }

                    const string insertQuery =
                        "INSERT INTO [Matches] " +
                        "([lostItemID], [foundItemID], " +
                        " [matchedBy],  [matchDate], " +
                        " [remarks],    [status]) " +
                        "VALUES (?, ?, ?, Date(), ?, 'Pending')";

                    using (OleDbCommand insertCmd =
                        new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("?", lostItemID);
                        insertCmd.Parameters.AddWithValue("?", foundItemID);
                        insertCmd.Parameters.AddWithValue("?", matchedBy);
                        insertCmd.Parameters.AddWithValue("?", remarks ?? "");
                        insertCmd.ExecuteNonQuery();
                    }

                    
                    const string matchStatusQuery =
                        "UPDATE [Items] SET [status] = 'Matched' WHERE [itemID] = ?";

                    using (OleDbCommand mc1 = new OleDbCommand(matchStatusQuery, conn))
                    {
                        mc1.Parameters.AddWithValue("?", lostItemID);
                        mc1.ExecuteNonQuery();
                    }
                    using (OleDbCommand mc2 = new OleDbCommand(matchStatusQuery, conn))
                    {
                        mc2.Parameters.AddWithValue("?", foundItemID);
                        mc2.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error creating match: " + ex.Message;
                return false;
            }
        }

        

        public bool CreateMatchByStringID(string lostItemID,
                                          string foundItemID,
                                          string matchedBy,
                                          string remarks,
                                          out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string checkQuery =
                        "SELECT COUNT(*) FROM [Matches] " +
                        "WHERE [lostItemID]  = ? " +
                        "AND   [foundItemID] = ? " +
                        "AND   [status]      = 'Pending'";

                    using (OleDbCommand checkCmd =
                        new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", lostItemID);
                        checkCmd.Parameters.AddWithValue("?", foundItemID);

                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            errorMessage =
                                "These two items are already matched " +
                                "and pending confirmation.";
                            return false;
                        }
                    }

                    const string insertQuery =
                        "INSERT INTO [Matches] " +
                        "([lostItemID], [foundItemID], " +
                        " [matchedBy],  [matchDate], " +
                        " [remarks],    [status]) " +
                        "VALUES (?, ?, ?, Date(), ?, 'Pending')";

                    using (OleDbCommand insertCmd =
                        new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("?", lostItemID);
                        insertCmd.Parameters.AddWithValue("?", foundItemID);
                        insertCmd.Parameters.AddWithValue("?", matchedBy);
                        insertCmd.Parameters.AddWithValue("?", remarks ?? "");
                        insertCmd.ExecuteNonQuery();
                    }

                    
                    const string matchStatusQuery =
                        "UPDATE [Items] SET [status] = 'Matched' WHERE [itemID] = ?";

                    using (OleDbCommand mc1 = new OleDbCommand(matchStatusQuery, conn))
                    {
                        mc1.Parameters.AddWithValue("?", lostItemID);
                        mc1.ExecuteNonQuery();
                    }
                    using (OleDbCommand mc2 = new OleDbCommand(matchStatusQuery, conn))
                    {
                        mc2.Parameters.AddWithValue("?", foundItemID);
                        mc2.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error creating match: " + ex.Message;
                return false;
            }
        }

        
        public DataRow GetMatchInfoForItem(string itemID)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "SELECT m.[matchID], m.[matchDate], m.[remarks], m.[status], " +
                        "       m.[lostItemID], m.[foundItemID], " +
                        "       li.[name] AS lostName, li.[reporter] AS lostReporter, " +
                        "       fi.[name] AS foundName, fi.[reporter] AS foundReporter " +
                        "FROM ([Matches] AS m " +
                        "INNER JOIN [Items] AS li ON m.[lostItemID]  = li.[itemID]) " +
                        "INNER JOIN [Items] AS fi ON m.[foundItemID] = fi.[itemID] " +
                        "WHERE m.[lostItemID] = ? OR m.[foundItemID] = ? " +
                        "ORDER BY m.[matchDate] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", itemID);
                        cmd.Parameters.AddWithValue("?", itemID);

                        DataTable dt = new DataTable();
                        new OleDbDataAdapter(cmd).Fill(dt);

                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
            catch { return null; }
        }

        

        public DataTable GetAllMatches()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "SELECT m.[matchID], " +
                        "       li.[name]     AS lostItemName, " +
                        "       li.[reporter] AS lostReporter, " +
                        "       fi.[name]     AS foundItemName, " +
                        "       fi.[reporter] AS foundReporter, " +
                        "       m.[matchedBy], " +
                        "       m.[matchDate], " +
                        "       m.[remarks], " +
                        "       m.[status], " +
                        "       m.[lostItemID], " +
                        "       m.[foundItemID] " +
                        "FROM ([Matches] AS m " +
                        "INNER JOIN [Items] AS li " +
                        "       ON m.[lostItemID]  = li.[itemID]) " +
                        "INNER JOIN [Items] AS fi " +
                        "       ON m.[foundItemID] = fi.[itemID] " +
                        "ORDER BY m.[matchDate] DESC";

                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading matches: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

       

        public bool UpdateMatchStatus(int matchID,
                                      string status,
                                      out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "UPDATE [Matches] SET [status] = ? " +
                        "WHERE [matchID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", matchID);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error updating match: " + ex.Message;
                return false;
            }
        }

        

        public bool ArchiveItem(string itemID, out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "UPDATE [Items] SET [status] = 'Archived' " +
                        "WHERE [itemID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", itemID);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            errorMessage =
                                $"No item found with ID \"{itemID}\".";
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error archiving item: " + ex.Message;
                return false;
            }
        }

        
        public List<Item> GetArchivedItems()
        {
            List<Item> items = new List<Item>();

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "SELECT * FROM [Items] " +
                        "WHERE [status] = 'Archived' " +
                        "ORDER BY [date] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            items.Add(ReadItem(dr));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading archived items: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return items;
        }

        
        private List<Item> GetItemsByStatus(string status, string errorPrefix)
        {
            List<Item> items = new List<Item>();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "SELECT * FROM [Items] " +
                        "WHERE [status] = ? " +
                        "ORDER BY [date] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", status);
                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                items.Add(ReadItem(dr));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorPrefix + ": " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }

       
        private static string CopyPhoto(string sourcePath,
                                        string targetFolder,
                                        string baseFileName)
        {
            if (string.IsNullOrEmpty(sourcePath) ||
                !File.Exists(sourcePath))
                return "";

            try
            {
                string ext = Path.GetExtension(sourcePath);
                string dest = Path.Combine(targetFolder, baseFileName + ext);
                File.Copy(sourcePath, dest, overwrite: true);
                return dest;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Photo copy failed: " + ex.Message,
                    "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
        }

        
        public (string reason, string adminName) GetArchiveInfoForItem(string itemID)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string query =
                        "SELECT [reason], [adminName] FROM [ArchivedItems] WHERE [itemID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", itemID);
                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                                return (dr["reason"]?.ToString() ?? "", dr["adminName"]?.ToString() ?? "");
                        }
                    }
                }
            }
            catch { }
            return ("", "");
        }

        public bool ArchiveItem(string itemID, string adminName, string reason, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    
                    const string insertQuery =
                        "INSERT INTO [ArchivedItems] ([itemID], [reason], [adminName]) " +
                        "VALUES (?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", itemID);
                        cmd.Parameters.AddWithValue("?", reason);
                        cmd.Parameters.AddWithValue("?", adminName);
                        cmd.ExecuteNonQuery();
                    }

                    
                    const string updateQuery =
                        "UPDATE [Items] SET [status] = 'Archived' WHERE [itemID] = ?";

                    using (OleDbCommand cmd2 = new OleDbCommand(updateQuery, conn))
                    {
                        cmd2.Parameters.AddWithValue("?", itemID);
                        cmd2.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error archiving item: " + ex.Message;
                return false;
            }
        }

        public DataTable GetArchivedReports()
        {
            DataTable dt = new DataTable();

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string query =
                        "SELECT a.archiveID, " +
                        "       a.itemID, " +
                        "       i.name, " +
                        "       i.description, " +
                        "       i.location, " +
                        "       i.date, " +
                        "       a.reason, " +
                        "       a.adminName " +
                        "FROM ArchivedItems a " +
                        "INNER JOIN Items i ON a.itemID = i.itemID " +
                        "ORDER BY i.date DESC";

                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading archived reports: " + ex.Message);
            }

            return dt;
        }

        public List<Item> GetAllItemsIncludingArchived()
        {
            List<Item> items = new List<Item>();

            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM [Items] ORDER BY [date] DESC";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        items.Add(ReadItem(dr));
                }
            }

            return items;
        }


    }
}