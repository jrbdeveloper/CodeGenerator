using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.Data
{
    public partial class DataModel : ITemplate
    {
        private Arguments m_data;

        public DataModel(Arguments data)
        {
            m_data = data;
        }
    }
}