using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.Core.Contracts.Domain
{
    public partial class DomainContract : ITemplate
    {
        private Arguments m_data;

        public DomainContract(Arguments data)
        {
            m_data = data;
        }
    }
}
