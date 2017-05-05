using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.Core.Contracts.Data
{
    public partial class DataContract : ITemplate
    {
        private Arguments m_data;

        public DataContract(Arguments data)
        {
            m_data = data;
        }
    }
}