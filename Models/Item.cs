namespace haunted_house_backend.Models
{
    public class Item
    {
        public string UserId { get; set; }

        public string SaveId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Slot { get; set; }

        public string ImgPath { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }
    }
}
