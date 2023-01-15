namespace KahootInfrastructure.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Quiz Quiz { get; set; }
        public Role Role { get; set; }
    }
}