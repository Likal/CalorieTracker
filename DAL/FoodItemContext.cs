using System;
using System.Collections.Generic;
using System.Linq;
using System.CalorieTracker.Models;

namespace CalorieTracker.DAL
{
    public interface IStoreDailyFoodIntake {

     DailyFoodIntake GetDailyFoodIntake(Guid FoodItemsId, Guid DailyFoodItakeid);
     void AddDailyFoodItem(DailyFoodItem newDailyFoodItem);
     void UpdateDailyFoodItem(DailyFoodItem updatedDailyFoodItem);
     void DeleteDailyFoodItem(Guid id, Guid dailyfooditemid);

    }
}

