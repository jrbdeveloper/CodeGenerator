using System.IO;

namespace CodeGenerator.Classes
{
    public class Generator
    {
        private const string ERROR_MESSAGE = "File exists and/or protected. Verify and try again. ";
        private const string INTERFACE_PREFIX = "I";

        public Generator()
        {
        }

        public string Error { get; set; }

        public void GenerateInterface(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var filePath = criteria.Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
                var fileName = INTERFACE_PREFIX + criteria.Arguments.VerticleName + criteria.Extension;

                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\";
                    CreateDirectoryIfAbsent(filePath);
                }

                if (CanWriteFile(filePath + fileName))
                {
                    File.WriteAllText(filePath + fileName, criteria.Template.TransformText());
                }
                else
                {
                    Error = ERROR_MESSAGE + "[" + fileName + "]";
                }
            }
        }

        public void GenerateObject(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var filePath = criteria.Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
                var fileName = criteria.Arguments.VerticleName + criteria.Extension;

                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\";
                    CreateDirectoryIfAbsent(filePath);
                }

                if (CanWriteFile(filePath + fileName))
                {
                    File.WriteAllText(filePath + fileName, criteria.Template.TransformText());
                }
                else
                {
                    Error = ERROR_MESSAGE + "[" + fileName + "]";
                }
            }
        }
        
        public void GenerateAsset(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var filePath = criteria.Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
                var fileName = DetermineViewType(criteria.ViewType, criteria.Arguments) + criteria.Extension;

                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\" + criteria.Arguments.VerticleName + "\\";
                    CreateDirectoryIfAbsent(filePath);
                }

                if (CanWriteFile(filePath + fileName))
                {
                    File.WriteAllText(filePath + fileName, criteria.Template.TransformText());
                }
                else
                {
                    Error = ERROR_MESSAGE + "[" + fileName + "]";
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