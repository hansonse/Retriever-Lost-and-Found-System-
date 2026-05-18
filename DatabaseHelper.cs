using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    
    public static class DatabaseHelper
    {
        
        private static readonly string DbPath =
            @"C:\Users\chiel\Desktop\(DRAFT) OOP 2 FINAL PROJECT - Copy\" +
            @"(Draft2) Retriever.accdb";

        private static readonly string ConnString =
            $"Provider=Microsoft.ACE.OLEDB.12.0;" +
            $"Data Source={DbPath};" +
            $"Persist Security Info=False;";

        
        public static readonly string ImagesFolder = @"C:\RetrieverImages\";

        
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnString);
        }

        
        public static bool TestConnection()
        {
            try
            {
                using (OleDbConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed:\n" + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        
        public static void EnsureFolderExists()
        {
            Directory.CreateDirectory(ImagesFolder + @"lost\");
            Directory.CreateDirectory(ImagesFolder + @"found\");
        }
    }
}