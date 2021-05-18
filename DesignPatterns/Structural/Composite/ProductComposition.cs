using System;

namespace DesignPatterns.Structural.Composite
{
    //Leaf
    public class ProductComposition : IProduct
    {
        public string Name { get; set; }

        public ProductComposition(string name)
        {
            Name = name;
        }
        public void ShowProducts(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
        }
    }
}