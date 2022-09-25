using System;
using Module2HW2.Entity;

namespace Module2HW2.Storage
{
    public class ProductStorage: IProductStorage
    {
        private IProduct[] _products;
        private int _size;
        private int _index = 0;

        public ProductStorage(int size)
        {
            _size = size;
            _products = new IProduct[_size];
        }

        public void Add(IProduct product)
        {
            if (_size <= 0)
            {
                return;
            }

            bool exist = false;

            foreach (IProduct item in _products)
            {
                if (null == item)
                {
                    break;
                }

                if (item.Sku == product.Sku)
                {
                    exist = true;
                    break;
                }
            }

            if (!exist)
            {
                _size--;
                _products[_index++] = product;
            }
        }

        public IProduct GetProduct()
        {
            return _products[GetRandNum()];
        }

        private int GetRandNum()
        {
            Random rnd = new Random();

            return rnd.Next(0, _products.Length);
        }
    }
}

