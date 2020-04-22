using SQLite;
using System;

namespace WHMIS.Models
{
    public class NoteItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
