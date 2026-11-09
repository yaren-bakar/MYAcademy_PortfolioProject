namespace MYAcademy_PortfolioProject.Entities
{
    public class SkillCategory
    {
        public int SkillCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }  
        public string Icon { get; set; }

        public List<Skill> Skills { get; set;  }
    }
}
