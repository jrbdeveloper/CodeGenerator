using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Scripts
{
    public partial class CreateScript : ITemplate
    {
        private Arguments m_data;

        public CreateScript(Arguments data)
        {
            m_data = data;
        }
    }
}