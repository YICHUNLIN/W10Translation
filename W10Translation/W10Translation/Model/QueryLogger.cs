using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace W10Translation
{
    public class QueryLogger
    {
        private string _logpath = "";
        private string _logFolder = "log";
        
        public QueryLogger(string logpath)
        {
            _logpath = logpath + "/" + _logFolder;
            if (!Directory.Exists(_logpath))
            {
                Directory.CreateDirectory(_logpath);
            }
        }
        
        public void addQueryLogXml(Query q)
        {
            //要用thread
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Query));
            string pn = _logpath + "/" + DateTime.Now.Month + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second+DateTime.Now.Millisecond+ ".xml";
            System.IO.FileStream file = System.IO.File.Create(pn);
            writer.Serialize(file, q);
            file.Close();
        }
        public List<Query> LoadQueryLogXml()
        {
            List<string> files = new List<string>( Directory.GetFiles(_logpath, "*.xml"));
            List<Query> qs = new List<Query>();
            foreach(string f in files)
            {
                Console.WriteLine(f);
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Query));
                System.IO.StreamReader r = new System.IO.StreamReader(f);

                Query qc = (Query)reader.Deserialize(r);
                r.Close();
                qs.Add(qc);
            }
            return qs;
        }


    }
}
