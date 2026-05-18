using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public class Item
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string LocationSurrendered { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }   
        public string Reporter { get; set; }
        public string ImagePath { get; set; }
        public string Visibility { get; set; }
        public int UserID { get; set; }

        public Item() { }

        public Item(string itemID,
                    string name,
                    string description,
                    string location,
                    string locationSurrendered,
                    DateTime date,
                    string status,
                    string category,
                    string reporter,
                    string imagePath,
                    string visibility,
                    int userID = 0)
        {
            ItemID = itemID;
            Name = name;
            Description = description;
            Location = location;
            LocationSurrendered = locationSurrendered;
            Date = date;
            Status = status;
            Category = category;
            Reporter = reporter;
            ImagePath = imagePath;
            Visibility = visibility;
            UserID = userID;
        }
    }
}
