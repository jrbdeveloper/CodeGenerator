using System.IO;

namespace CodeGenerator.Classes
{
    public class Generator
    {
        private const string INTERFACE_PREFIX = "I";        

        public Arguments Arguments { get; set; }

        public Generator(Arguments args)
        {
            Arguments = args;
        }

        public void GenerateInterface(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var filePath = Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
                var fileName = INTERFACE_PREFIX + Arguments.VerticleName + criteria.Extension;

                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\";
                    CreateDirectoryIfAbsent(filePath);
                }

                if (CanWriteFile(filePath + fileName))
                {
                    File.WriteAllText(filePath + fileName, criteria.Template.TransformText());
                }
            }
        }

        public void GenerateObject(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var filePath = Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
                var fileName = Arguments.VerticleName + criteria.Extension;

                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\";
                    CreateDirectoryIfAbsent(filePath);
                }

                if (CanWriteFile(filePath + fileName))
                {
                    File.WriteAllText(filePath + fileName, criteria.Template.TransformText());
                }              
            }
        }
        
        public void GenerateAsset(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var filePath = Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
                var fileName = DetermineViewType(criteria.ViewType, Arguments) + criteria.Extension;

                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\" + Arguments.VerticleName + "\\";
                    CreateDirectoryIfAbsent(filePath);
                }

                if (CanWriteFile(filePath + fileName))
                {
                    File.WriteAllText(filePath + fileName, criteria.Template.TransformText());
                }
            }            
        }

        private string DetermineViewType(ViewType type, Arguments args)
        {
            var returnVal = string.Empty;

            switch (type)
            {
                case ViewType.Create:
                    returnVal = "Create";
                    break;

                case ViewType.Details:
                    returnVal = "Details";
                    break;

                case ViewType.Edit:
                    returnVal = "Edit";
                    break;

                case ViewType.List:
                    returnVal = "Index";
                    break;

                case ViewType.Specific:
                    returnVal = args.VerticleName;
                    break;

                default:
                    returnVal = args.VerticleName;
                    break;
            }

            return returnVal;
        }

        private bool CanWriteFile(string file)
        {
            if (File.Exists(file))
            {
                var fileInfo = new FileInfo(file);

                if (fileInfo.IsReadOnly)
                {
                    return false;
                }
            }

            return true;
        }

        private void CreateDirectoryIfAbsent(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}