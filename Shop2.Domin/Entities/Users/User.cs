namespace Shop2.Doming.Entities.Users
{
    public class User
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<UserInRole> UserInRoles { get; set; }
    }
}
