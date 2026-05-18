using System;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    
    public class ClaimRequest
    {
        public string RequestID { get; set; }   
        public string ItemID { get; set; }   
        public string ItemName { get; set; }   
        public string Category { get; set; }
        public string Location { get; set; }
        public DateTime DateFound { get; set; }
        public string Username { get; set; }   
        public string FullName { get; set; }   
        public string StudentID { get; set; }   
        public DateTime DateFiled { get; set; }
        public string Status { get; set; }   
        public string Remarks { get; set; }   

        public ClaimRequest() { }

        public ClaimRequest(string requestID, string itemID, string itemName,
                            string category, string location, DateTime dateFound,
                            string username, string fullName, string studentID,
                            DateTime dateFiled, string status, string remarks)
        {
            RequestID = requestID;
            ItemID = itemID;
            ItemName = itemName;
            Category = category;
            Location = location;
            DateFound = dateFound;
            Username = username;
            FullName = fullName;
            StudentID = studentID;
            DateFiled = dateFiled;
            Status = status;
            Remarks = remarks;
        }
    }
}
