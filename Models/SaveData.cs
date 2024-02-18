namespace haunted_house_backend.Models
{
    public class SaveData
    {
        public string UserId { get; set; }

        public string Id { get; set; }

        public int Slot { get; set; }

        public string UserName { get; set; }

        public List<Item> Items { get; set; }

        public bool IsClear { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }

    }
}
