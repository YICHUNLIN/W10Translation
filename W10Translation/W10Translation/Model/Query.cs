using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10Translation
{
    public class Query
    {
        private string _oriq;
        private List<string> _words;
        private int _count;
        private string _result;
        public Query()
        {

        }

        public Query(string rawLine)
        {
            List<string> raws = new List<string>(rawLine.Split('⊗'));
            if(raws.Count == 4)
            {
                _count = Int32.Parse(raws[0]);
                _oriq = raws[1];
                _result = raws[2];
                _words = new List<string>(raws[3].Split(' '));
            }
        }
        public Query(string q,string r)
        {
            string qq = q.Replace('\n', ' ').Replace('\r', ' ');
            string rr = r.Replace('\n', ' ').Replace('\r', ' ');
            _oriq = qq;
            _words = new List<string>(qq.Split(' '));
            _count = _words.Count;
            _result = r;
        }

        public string Ori
        {
            get
            {
                return _oriq;
            }
            set
            {
                _oriq = value;
            }
        }
        public List<string> Words
        {
            get
            {
                return _words;
            }
            set
            {
                _words = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        private string Words2String()
        {
            string s = "";

            foreach(string word in _words)
            {
                s += word + " ";
                
            }
            return s;
        }
        public override string ToString()
        {
            return _count+ "⊗" + _oriq + "⊗" + _result + "⊗" + Words2String();
        }

    }
}
