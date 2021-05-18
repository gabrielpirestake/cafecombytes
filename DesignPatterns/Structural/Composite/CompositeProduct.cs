using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite
{
    //Composite
    public class CompositeProduct : IProduct, IEnumerable<IProduct>
    {
        private readonly List<IProduct> _list = new List<IProduct>();

        public string Name { get; set; }

        public CompositeProduct(string name)
        {
            Name = name;
        }

        public void AddChild(IProduct product)
        {
            _list.Add(product);
        }

        public void RemoveChild(IProduct filha)
        {
            _list.Remove(filha);
        }

        public IProduct GetChild(int index)
        {
            return _list[index];
        }

        public IProduct GetChild(string name)
        {
            return _list.First(c => c.Name == name);
        }

        public IEnumerable<IProduct> GetList()
        {
            return _list;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            return ((IEnumerable<IProduct>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IProduct>)_list).GetEnumerator();
        }

        public void ShowProducts(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);

            foreach (var product in _list)
            {
                product.ShowProducts(sub + 2);
            }
        }
    }
}