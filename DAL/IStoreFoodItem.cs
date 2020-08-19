using System;
using System.Collections.Generic;
using System.Linq;
using System.CalorieTracker.Models;

namespace CalorieTracker.DAL
{
    public interface IStoreFoodItem {

     FoodItem GetById(Guid id);
     List<FoodItem> GetAll();


     void Create(FoodItem item);
     void Update(FoodItem updateditem);
     void Delete(Guid id);

    }
}

