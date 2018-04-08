using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W10Translation
{
    public class Configer
    {
        private string _bathpath = "C:/ProgramData";
        private string _dir = "VicTranslation";
        private string _configDir = "";
        private string _configName = "config.xml";
        private string _settingConfigName = "setting.xml";
        private ConfigXml _cx = null;
        private SettingXml _sx = null;
        public Configer()
        {
            _configDir = _bathpath + "/" + _dir;
            createVicTranslationDir();
            _cx = (ConfigXml)(new ConfigXml().getConfigObject(_configDir, _configName));
            _sx = (SettingXml)(new SettingXml().getConfigObject(_configDir , _settingConfigName));
        }

        /**
         產生程式資料夾
             */
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

        public SettingXml SettingConfigxml
        {
            get
            {
                return _sx;
            }
        }

        public string FullCredential
        {
            get
            {
                return _cx.CredentialPath + "/" + _cx.CredentialName;
            }
        }

        /**
         儲存setting xml檔
             */
        public void SaveSettingXml()
        {
            string path = _configDir + "/" + _settingConfigName;
            _sx.Save(path);
        }
        
    }
}
