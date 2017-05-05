using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Views
{
    public partial class View : ITemplate
    {
        private Arguments m_data;

        public View(Arguments data)
        {
            m_data = data;
        }
    }
}