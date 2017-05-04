using CodeGenerator.Classes;

namespace CodeGenerator.Templates.Core.Contracts.Domain
{
    public partial class DomainContract
    {
        private Arguments m_data;

        public DomainContract(Arguments data)
        {
            m_data = data;
        }
    }
}
