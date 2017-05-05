using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Views
{
    public partial class CreateView : ITemplate
    {
        private Arguments m_data;

        public CreateView(Arguments data)
        {
            m_data = data;
        }
    }
}