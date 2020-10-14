using CVnder.interfaces;

namespace CVndr.Models
{
  class Soda : Item, ITaxable
  {
    public Soda(int once, bool taxable, float rate) : base(name, stock, price) 
    {
      Once = once;
      Taxable = taxable;
      Rate = rate;
    }

    public int Once {get; set;}
    public bool Taxable { get; set;}
    public float Rate { get; set;}

    
  }
}