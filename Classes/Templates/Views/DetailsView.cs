using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Views
{
    public partial class DetailsView : ITemplate
    {
        private Arguments m_data;

        public DetailsView(Arguments data)
        {
            m_data = data;
        }
    }
}