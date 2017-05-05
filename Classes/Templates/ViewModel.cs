using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.Core.ViewModel
{
    public partial class ViewModel : ITemplate
    {
        private Arguments m_data;

        public ViewModel(Arguments data)
        {
            m_data = data;
        }
    }
}