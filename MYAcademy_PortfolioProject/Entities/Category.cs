namespace MYAcademy_PortfolioProject.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Project> Projects { get; set; }

    }
}
