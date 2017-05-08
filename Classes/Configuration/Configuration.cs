using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CodeGenerator.Classes.Configuration
{
    [DataContract]
    public class Configuration
    {
        private List<Solution> _solutions;

        [DataMember]
        public List<Solution> Solutions
        {
            get
            {
                if (_solutions == null)
                {
                    _solutions = new List<Solution>();
                }

                return _solutions;
            }

            set { _solutions = value; }
        }

        public Configuration()
        {
            //GetConfiguration();
        }

        private Configuration GetConfiguration()
        {
            try
            {
                var ser = new DataContractJsonSerializer(typeof(Configuration));
                var file = File.OpenRead("file.json");

                if (file.Length > 0)
                {
                    var config = (Configuration)ser.ReadObject(file);
                    file.Close();

                    return (config != null)
                    ? config
                    : new Configuration();
                }

                file.Close();

                return new Configuration();
            }
            catch (FileNotFoundException ex)
            {
                return new Configuration();
            }
        }

        public Solution Find(string name)
        {
            var list = GetConfiguration().Solutions;
            var result = from item in list
                         where item.Name == name
                         select (Solution)item;

            return result.SingleOrDefault();
        }

        public void Update(Solution solution)
        {
                       
        }

        public void Save(Solution solution)
        {
            Solutions.Add(solution);
            
            var ser = new DataContractJsonSerializer(typeof(Configuration));
            var file = File.OpenWrite("file.json");
            ser.WriteObject(file, this);
            file.Close();
        }
    }
}