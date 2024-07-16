namespace OOP.Class
{
    /// <summary>
    ///  Indexer is a special kind of property that allows accessing elements of a list by an index.
    ///  If a class has the semantics of a list, or collection, we can define an indexer property for it.This way it’s easier to get or set items in the collection.
    /// </summary>
    public class SampleHttpCookie
    {
        private readonly Dictionary<string, string> _cookies;
        public DateTime Expire { get; set; }
        public SampleHttpCookie()
        {
            _cookies=new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _cookies[key]; }
            set { _cookies[key] = value;}
        }

        // To replace the indexer you will need to create 2 method
        public void SetItem(string key, string value)
        {
            _cookies[key] = value;
        }
        public string GetItem(string key)
        {
            return _cookies[key];
        }
    }
}
