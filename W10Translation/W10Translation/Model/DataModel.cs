using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace W10Translation
{
    public class QCounter
    {
        private int _wc = 0;
        private int _tc = 0;
        private string _fn = "/counter.xml";
        public QCounter()
        {

        }
        public QCounter(QCounter qc)
        {
            if(qc != null)
            {
                _wc = qc._wc;
                _tc = qc._tc;
            }
        }
        public QCounter(int wc, int tc)
        {
            _wc = wc;
            _tc = tc;
        }
        public int WordCounter
        {
            get
            {
                return _wc;
            }
            set
            {
                _wc = value;
            }
        }
        public int TimesCounter
        {
            get
            {
                return _tc;
            }
            set
            {
                _tc = value;
            }
        }
        public void Save(string path)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(QCounter));
            string pn = path + _fn;
            System.IO.FileStream file = System.IO.File.Create(pn);
            writer.Serialize(file, this);
            file.Close();
        }

        public static QCounter getCounter(string path)
        {
            string pn = path + "/counter.xml";
            if (System.IO.File.Exists(pn))
            {
                Console.WriteLine("A");
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(QCounter));
                System.IO.StreamReader file = new System.IO.StreamReader(pn);
                
                QCounter qc = (QCounter)reader.Deserialize(file);
                file.Close();
                return qc;
            }
            Console.WriteLine("B");
            return null;
        }
    }

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
            //_qs = new List<Query>(_ql.LoadQueryLog());
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
