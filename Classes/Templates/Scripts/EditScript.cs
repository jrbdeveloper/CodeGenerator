using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Scripts
{
    public partial class EditScript : ITemplate
    {
        private Arguments m_data;

        public EditScript(Arguments data)
        {
            m_data = data;
        }
    }
}