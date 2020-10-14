namespace CVndr.Models
{
  class Item
  {

    public string Name {get; set;}

    public int Stock {get; set;}

    public double Price {get; set;}
    public bool InStock {get; set;}
    public Item(string name, int stock, double price)
    {
      InStock = true;
      Name = name;
      Stock = stock;
      Price = price;
    }
  }
}