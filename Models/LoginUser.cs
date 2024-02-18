using haunted_house_backend.Enum;

namespace haunted_house_backend.Models
{
    public class LoginUser
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public UserRole Role { get; set; }

        public string Salt { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }
    }
}
