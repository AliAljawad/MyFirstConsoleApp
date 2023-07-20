namespace MyFirstConsoleApp
{
    public class Phone : BaseProduct
    {
        public Phone(int id, string? brand, string? name, string? color, decimal? cost, decimal? price) : base(id,brand,name, color, cost, price) { }
    }
}