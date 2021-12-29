namespace AbstractFactoryPatternDemo
{
    public class FactoryDataItem
    {
        private object _dataitem;
        public object DataItem
        {
            get
            {
                return _dataitem;
            }
        }
        public FactoryDataItem(object dataItem)
        {
            _dataitem = dataItem;
        }
    }
}