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
                var file = new FileLibrary();
                var filePath = file.GetFilePath(criteria);
                var fileName = INTERFACE_PREFIX + criteria.Arguments.VerticleName + criteria.Extension;
                
                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\";
                    file.CreateDirectory(filePath);
                }

                var fullPath = file.GetFullPath(filePath, fileName);

                WriteFile(file, fileName, fullPath, criteria);
            }
        }

        public void GenerateObject(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var file = new FileLibrary();
                var filePath = file.GetFilePath(criteria);
                var fileName = criteria.Arguments.VerticleName + criteria.Extension;
                
                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\";
                    file.CreateDirectory(filePath);
                }

                var fullPath = file.GetFullPath(filePath, fileName);

                WriteFile(file, fileName, fullPath, criteria);
            }
        }
        
        public void GenerateAsset(GeneratorCriteria criteria)
        {
            if (criteria.Project.SelectedValue != null)
            {
                var file = new FileLibrary();
                var filePath = file.GetFilePath(criteria);
                var fileName = file.DetermineName(criteria.ViewType, criteria.Arguments) + criteria.Extension;
                
                if (!string.IsNullOrEmpty(criteria.FolderPath))
                {
                    filePath += criteria.FolderPath + "\\" + criteria.Arguments.VerticleName + "\\";
                    file.CreateDirectory(filePath);
                }

                var fullPath = file.GetFullPath(filePath, fileName);

                WriteFile(file, fileName, fullPath, criteria);
            }            
        }

        private void WriteFile(FileLibrary file, string fileName, string fullPath, GeneratorCriteria criteria)
        {
            if (file.CanWrite(fullPath))
            {
                if (file.CanGenerate(fullPath, criteria.ReGenCheck))
                {
                    file.Write(fullPath, criteria);
                }
            }
            else
            {
                Error = ERROR_MESSAGE + "[" + fileName + "]";
            }
        }
    }
}