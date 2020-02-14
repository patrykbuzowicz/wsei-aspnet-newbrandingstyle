namespace NewBrandingStyle.Web.Entities
{
    public class CompanyEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }

        public bool IsPublic { get; set; }

        public int UserId { get; set; }
    }
}
