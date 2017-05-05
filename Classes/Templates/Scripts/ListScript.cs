using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Scripts
{
    public partial class ListScript : ITemplate
    {
        private Arguments m_data;

        public ListScript(Arguments data)
        {
            m_data = data;
        }
    }
}