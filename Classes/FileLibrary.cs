using System.IO;
using System.Windows.Forms;

namespace CodeGenerator.Classes
{
    public class FileLibrary
    {
        public string GetNamespace(string prefix, string sufix)
        {
            sufix = (!string.IsNullOrEmpty(sufix))
                ? "." + sufix.Replace("\\", ".")
                : string.Empty;

            return prefix + sufix;
        }

        public string DetermineName(ViewType type, Arguments args)
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

        public string GetFilePath(GeneratorCriteria criteria)
        {
            return criteria.Arguments.SolutionPath + "\\" + criteria.Project.SelectedValue + "\\";
        }

        public string GetFullPath(string filePath, string fileName)
        {
            return filePath + fileName;
        }

        public string GetAppendedFolders(GeneratorCriteria criteria)
        {
            return criteria.FolderPath + "\\" + criteria.Arguments.VerticleName + "\\";
        }

        public bool CanGenerate(string file, CheckBox regen)
        {
            if (File.Exists(file))
            {
                if (!regen.Checked)
                {
                    var msg = MessageBox.Show(null, "The file exists (" + file + "). Would you like to re-generate it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    regen.Checked = (msg == DialogResult.Yes) ? true : false;

                    return msg == DialogResult.Yes;
                }
            }

            return true;
        }

        public bool CanWrite(string file)
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

        public void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void Write(string fullPath, GeneratorCriteria criteria)
        {
            File.WriteAllText(fullPath, criteria.Template.TransformText());
        }
    }
}