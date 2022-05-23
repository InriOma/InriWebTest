namespace InriWebTest.Models
{
    public class User
    {

        private UserStoreContext context;

        public int id { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Available { get; set; }
    }
}
