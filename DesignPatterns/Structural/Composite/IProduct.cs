namespace DesignPatterns.Structural.Composite
{
    //Component
    public interface IProduct
    {
        string Name { get; set; }
        void ShowProducts(int sub);
    }
}