namespace MYAcademy_PortfolioProject.Entities
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string SkillName { get; set; }

        public int SkillCategoryID { get; set; }

        public SkillCategory SkillCategory { get; set; }
    }
}
