using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Scripts
{
    public partial class DetailsScript : ITemplate
    {
        private Arguments m_data;

        public DetailsScript(Arguments data)
        {
            m_data = data;
        }
    }
}