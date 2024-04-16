namespace ToDoList.Models
{
    public class User
    {
        public int id_user { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public List<Item> items { get; set; }
    }
}
