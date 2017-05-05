using CodeGenerator.Classes.Templates;
using System.Windows.Forms;

namespace CodeGenerator.Classes
{
    public class GeneratorCriteria
    {
        public ComboBox Project { get; set; }

        public ITemplate Template { get; set; }

        public string Extension { get; set; }

        public string FolderPath { get; set; }
        
        public ViewType ViewType { get; set; }
    }
}