using System.Collections.Generic;

namespace CodeGenerator.Classes.Configuration
{
    public class Solution
    {
        private List<Asset> _assets;

        public string Path { get; set; }

        public string Name { get; set; }
        
        public string VerticleName { get; set; }

        public List<Project> Projects { get; set; }

        public List<Asset> Assets
        {
            get
            {
                if (_assets == null)
                {
                    _assets = new List<Asset>();
                }

                return _assets;
            }

            set { _assets = value; }
        }
    }
}