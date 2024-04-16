namespace ToDoList.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int id_user { get; set; }

        public User users { get; set; }
    }
}
