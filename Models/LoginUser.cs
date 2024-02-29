using haunted_house_backend.Enum;

namespace haunted_house_backend.Models
{
    public class LoginUser
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public string Salt { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
