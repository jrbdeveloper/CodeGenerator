using CodeGenerator.Classes;

namespace CodeGenerator.Templates.Core.Contracts.Data
{
    public partial class DataContract
    {
        private Arguments m_data;

        public DataContract(Arguments data)
        {
            m_data = data;
        }
    }
}