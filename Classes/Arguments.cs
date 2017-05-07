namespace CodeGenerator.Classes
{
    public class Arguments
    {
        public string Namespace
        {
            get
            {
                Folders = (!string.IsNullOrEmpty(Folders)) 
                    ? "." + Folders.Replace("\\", ".") 
                    : string.Empty;

                return Project + Folders;
            }
        }

        public string SolutionPath { get; set; }

        public string SolutionName { get; set; }

        public string Project { get; set; }

        public string Folders { get; set; }

        public string VerticleName { get; set; }

        public string DataContracts { get; set; }

        public string DomainContracts { get; set; }

        public string ViewModels { get; set; }
    }
}