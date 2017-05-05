using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.Domain
{
    public partial class DomainModel : ITemplate
    {
        private Arguments m_data;

        public DomainModel(Arguments data)
        {
            m_data = data;
        }
    }
}