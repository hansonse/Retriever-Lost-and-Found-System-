using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    
    public class ClaimRequestManager
    {
        
        private static ClaimRequest ReadRequest(OleDbDataReader dr)
        {
            return new ClaimRequest(
                dr["requestID"].ToString(),
                dr["itemID"].ToString(),
                dr["itemName"].ToString(),
                dr["category"].ToString(),
                dr["location"].ToString(),
                Convert.ToDateTime(dr["dateFound"]),
                dr["username"].ToString(),
                dr["fullName"].ToString(),
                dr["studentID"].ToString(),
                Convert.ToDateTime(dr["dateFiled"]),
                dr["status"].ToString(),
                dr["remarks"].ToString()
            );
        }

        
        public string SubmitRequest(string itemID, string itemName,
                                    string category, string location,
                                    DateTime dateFound,
                                    string username, string fullName,
                                    string studentID,
                                    string userMessage,
                                    out string errorMessage)
        {
            errorMessage = "";


            if (HasPendingRequest(username, itemID, out string checkErr))
            {
                errorMessage = "You already have a pending claim for this item.";
                return "";
            }
            if (!string.IsNullOrEmpty(checkErr))
            {
                errorMessage = "Could not verify existing requests: " + checkErr;
                return "";
            }

            string requestID = "REQ-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        "INSERT INTO [ClaimRequests] " +
                        "([requestID], [itemID], [itemName], [category], " +
                        " [location], [dateFound], [username], [fullName], " +
                        " [studentID], [dateFiled], [status], [remarks]) " +
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("p1", OleDbType.VarChar) { Value = requestID });
                        cmd.Parameters.Add(new OleDbParameter("p2", OleDbType.VarChar) { Value = itemID });
                        cmd.Parameters.Add(new OleDbParameter("p3", OleDbType.VarChar) { Value = itemName });
                        cmd.Parameters.Add(new OleDbParameter("p4", OleDbType.VarChar) { Value = category });
                        cmd.Parameters.Add(new OleDbParameter("p5", OleDbType.VarChar) { Value = location });
                        cmd.Parameters.Add(new OleDbParameter("p6", OleDbType.Date)
                        {
                            Value = (dateFound == DateTime.MinValue)
                                    ? DateTime.Now
                                    : dateFound
                        });
                        cmd.Parameters.Add(new OleDbParameter("p7", OleDbType.VarChar) { Value = username });
                        cmd.Parameters.Add(new OleDbParameter("p8", OleDbType.VarChar) { Value = fullName });
                        cmd.Parameters.Add(new OleDbParameter("p9", OleDbType.VarChar) { Value = studentID });
                        cmd.Parameters.Add(new OleDbParameter("p10", OleDbType.Date) { Value = DateTime.Now });
                        cmd.Parameters.Add(new OleDbParameter("p11", OleDbType.VarChar) { Value = "Pending" });
                        cmd.Parameters.Add(new OleDbParameter("p12", OleDbType.VarChar) { Value = userMessage ?? "" });

                        cmd.ExecuteNonQuery();
                    }
                }

                return requestID;
            }
            catch (Exception ex)
            {
                errorMessage = "Error submitting request:\n" + ex.Message;
                return "";
            }
        }

 

        private bool HasPendingRequest(string username, string itemID,
                                       out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string q =
                        "SELECT COUNT(*) FROM [ClaimRequests] " +
                        "WHERE [username] = ? AND [itemID] = ? " +
                        "AND   [status]   = 'Pending'";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {
                        
                        cmd.Parameters.Add(new OleDbParameter("p1", OleDbType.VarChar) { Value = username });
                        cmd.Parameters.Add(new OleDbParameter("p2", OleDbType.VarChar) { Value = itemID });

                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }


        public List<ClaimRequest> GetRequestsByUser(string username)
        {
            var list = new List<ClaimRequest>();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string q =
                        "SELECT * FROM [ClaimRequests] " +
                        "WHERE [username] = ? " +
                        "ORDER BY [dateFiled] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        using (OleDbDataReader dr = cmd.ExecuteReader())
                            while (dr.Read()) list.Add(ReadRequest(dr));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading your requests: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }



        public List<ClaimRequest> GetAllRequests()
        {
            var list = new List<ClaimRequest>();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string q =
                        "SELECT * FROM [ClaimRequests] " +
                        "ORDER BY [dateFiled] DESC";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                        while (dr.Read()) list.Add(ReadRequest(dr));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }



        public ClaimRequest GetRequestByID(string requestID)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string q =
                        "SELECT * FROM [ClaimRequests] WHERE [requestID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("?", requestID);
                        using (OleDbDataReader dr = cmd.ExecuteReader())
                            if (dr.Read()) return ReadRequest(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching request: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        public void ResetMatchForRejectedClaim(string itemID)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string q =
                        "UPDATE [Matches] SET [status] = 'Pending' " +
                        "WHERE ([lostItemID] = ? OR [foundItemID] = ?) " +
                        "AND [status] <> 'Confirmed'";
                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("?", itemID);
                        cmd.Parameters.AddWithValue("?", itemID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }



        public bool UpdateRequestStatus(string requestID, string status,
                                        string remarks, out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    const string q =
                        "UPDATE [ClaimRequests] " +
                        "SET [status] = ?, [remarks] = ? " +
                        "WHERE [requestID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", remarks ?? "");
                        cmd.Parameters.AddWithValue("?", requestID);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error updating request: " + ex.Message;
                return false;
            }
        }
    }
}
