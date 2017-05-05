﻿using CodeGenerator.Classes;
using CodeGenerator.Classes.Templates;

namespace CodeGenerator.Templates.UI.Views
{
    public partial class ListView : ITemplate
    {
        private Arguments m_data;

        public ListView(Arguments data)
        {
            m_data = data;
        }
    }
}