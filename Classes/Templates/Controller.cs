using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Controller
{
    public partial class Controller : ITemplate
    {
        private Arguments m_data;

        public Controller(Arguments data)
        {
            m_data = data;
        }
    }
}