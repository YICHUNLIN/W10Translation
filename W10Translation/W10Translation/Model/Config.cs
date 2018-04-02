using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W10Translation
{
    public class ConfigXml
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
        {}
    }

    public class Config
    {
        private string _bathpath = "C:/ProgramData";
        private string _dir = "VicTranslation";
        private string _configDir = "";
        private string _configName = "config.xml";
        private ConfigXml _cx = null;
        public Config()
        {
            _configDir = _bathpath + "/" + _dir;
            createVicTranslationDir();
            _cx = getConfig();
        }

        private void createVicTranslationDir()
        {
            if (!Directory.Exists(_configDir))
            {
                Directory.CreateDirectory(_configDir);
            }
        }

        public ConfigXml Configxml
        {
            get
            {
                return _cx;
            }
        }

        public string FullCredential
        {
            get
            {
                return _cx.CredentialPath + "/" + _cx.CredentialName;
            }
        }

        private ConfigXml getConfig()
        {
            string ph = _configDir + "/" + _configName;
            if (File.Exists(ph))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ConfigXml));
                System.IO.StreamReader r = new System.IO.StreamReader(ph);
                ConfigXml cx = (ConfigXml)reader.Deserialize(r);
                r.Close();
                return cx;
            }

            return this.initConfig();
        }

        private ConfigXml initConfig()
        {
            ConfigXml cx = new ConfigXml(_configDir, _configDir, "credential.json");
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ConfigXml));
            System.IO.FileStream file = System.IO.File.Create(_configDir + "/" + _configName);
            writer.Serialize(file, cx);
            file.Close();
            return cx;
        }


    }
}
