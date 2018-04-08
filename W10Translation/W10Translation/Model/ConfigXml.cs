using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10Translation
{
    public class ConfigXml : ConfigObject
    {
        private string _lp;
        private string _cd;
        private string _cdName = "";
        public string LogPath
        {
            get
            {
                return _lp;
            }
            set
            {
                _lp = value;
            }
        }
        public string CredentialName
        {
            get
            {
                return _cdName;
            }
            set
            {
                _cdName = value;
            }
        }
        public string CredentialPath
        {
            get
            {
                return _cd;
            }
            set
            {
                _cd = value;
            }
        }
        public ConfigXml(string lp, string cd, string cdname)
        {
            _lp = lp;
            _cd = cd;
            _cdName = cdname;
        }

        public ConfigXml()
        { }

        /**
         取得config檔
             */
        public override ConfigObject getConfigObject(string dir, string name)
        {
            string ph = dir + "/" + name;
            if (System.IO.File.Exists(ph))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ConfigXml));
                System.IO.StreamReader r = new System.IO.StreamReader(ph);
                ConfigXml cx = (ConfigXml)reader.Deserialize(r);
                r.Close();
                return cx;
            }
            return this.initConfig(dir, name);
        }

        /**
         初始化 config檔
             */
        private ConfigXml initConfig(string dir, string name)
        {
            ConfigXml cx = new ConfigXml(dir, dir, "credential.json");
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ConfigXml));
            System.IO.FileStream file = System.IO.File.Create(dir + "/" + name);
            writer.Serialize(file, cx);
            file.Close();
            return cx;
        }

    }
}
