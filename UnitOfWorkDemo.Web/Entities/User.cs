namespace UnitOfWorkDemo.Web.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Blog> Bloglar { get; set; }
    }
}
