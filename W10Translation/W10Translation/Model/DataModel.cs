using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace W10Translation
{
   
    public class DataModel
    {
        private List<Query> _qs = null;
        private QCounter _counter = null;
        private string _counterPath = "";
        private QueryLogger _ql;
        public DataModel(string path)
        {
            
            _counterPath = path;
            _counter = new QCounter(QCounter.getCounter(path));
            _ql = new QueryLogger(path);
            _qs = _ql.LoadQueryLogXml();
        }
        
        public Query addQuery(Query q)
        {
            _qs.Add(q);
            _counter.TimesCounter += 1;
            _counter.WordCounter += q.Count;
            _ql.addQueryLogXml(q);
            return q;
        }

        public List<Query> Qs
        {
            get
            {
                return _qs;
            }
        }

        public Query getQueryByIndex(int index)
        {
            if(index >-1 && index < _qs.Count)
            {
                return _qs[index];
            }
            return null;
        }
        
        public int WordCount
        {
            get
            {
                return _counter.WordCounter;
            }
        }

        public int TimesCount
        {
            get
            {
                return _counter.TimesCounter;
            }
        }
        /*
         寫入Counter
             */
        public void saveCounter()
        {
            _counter.Save(_counterPath);
        }
    }
}
