using CodeGenerator.Classes;

namespace CodeGenerator.Templates.Domain
{
    public partial class DomainModel
    {
        private Arguments m_data;

        public DomainModel(Arguments data)
        {
            m_data = data;
        }
    }
}