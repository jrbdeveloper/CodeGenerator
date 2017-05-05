using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Scripts
{
    public partial class Script : ITemplate
    {
        private Arguments m_data;

        public Script(Arguments data)
        {
            m_data = data;
        }
    }
}