using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Cloud.Translation.V2;
using Newtonsoft.Json;
using System.IO;
namespace W10Translation
{

    public class Model
    {
        private string _google_application_credentials = "";
        private TranslationClient _client = null;
        public Model(string gc)
        {
            _google_application_credentials = gc;
            try
            {
                _client = TranslationClient.Create(GoogleCredential.FromJson(File.ReadAllText(_google_application_credentials)));
            }
            catch(Exception e)
            {
                throw e;
            } 
        }
        
        /**
         執行轉換
             */
        public string doTranslate(string oristring)
        {
            string result = "";
            if (_client != null)
            {
                if(oristring != "")
                {
                    try
                    {
                        TranslationResult tr = _client.TranslateText(oristring, LanguageCodes.ChineseTraditional);
                        result = tr.TranslatedText;
                    }
                    catch(Exception e)
                    {
                        throw e;
                    }

                }
            }

            return result;
        }
    }
}
