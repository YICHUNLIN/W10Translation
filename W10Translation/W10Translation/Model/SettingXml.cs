using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10Translation
{
    public class SettingXml : ConfigObject
    {
        private int _translationMode;
        
        

        public SettingXml(int transMode)
        {
            _translationMode = transMode;
        }

        public SettingXml()
        {

        }

        public int TransLationMode
        {
            get
            {
                return _translationMode;
            }
            set
            {
                _translationMode = value;
            }
        }

        /**
         取得設定檔
             */
        public override ConfigObject getConfigObject(string dir,string name)
        {
            string ph = dir + "/" + name;
            if (System.IO.File.Exists(ph))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(SettingXml));
                System.IO.StreamReader r = new System.IO.StreamReader(ph);
                SettingXml sx = (SettingXml)reader.Deserialize(r);
                r.Close();
                return sx;
            }
            return this.initSetting(ph);
        }

        /**
         初始化 setting 檔
            */
        private SettingXml initSetting(string path)
        {
            SettingXml sx = new SettingXml(0);
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(SettingXml));
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, sx);
            file.Close();
            return sx;
        }

        /**
         儲存
             */
        public override void Save(string path)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(SettingXml));
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }
    }
}
