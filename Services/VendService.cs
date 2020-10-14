using System;
using System.Collections.Generic;
using CVndr.Models;

namespace CVndr.Service
{
  class CVndrService
  {
    public List<Item> Items{get; set;}

    internal void GetItems()
    {
      var stock = Items.FindAll(i => i.InStock = true);
    }
    public CVnderService()
    {
      Items = new list<Items>(){
        
      }
    }
  }
}