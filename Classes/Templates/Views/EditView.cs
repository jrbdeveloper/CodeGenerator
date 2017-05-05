using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Views
{
    public partial class EditView : ITemplate
    {
        private Arguments m_data;

        public EditView(Arguments data)
        {
            m_data = data;
        }
    }
}