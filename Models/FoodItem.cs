using System;
using System.Collections.Generic;


namespace CalorieTracker.Models
{
    public class FoodItem
    {
        public Guid Id { get; set; }

        public string FoodItemName { get; set; }

        public int CaloriePerServing { get; set; }

        public int CarbMacro { get; set; }

        public int ProtMacro { get; set; }

        public int FatMacro { get; set; }

        public int ServingSize {get; set; }

        public bool IsDeleted { get; set; }

        public List<FoodItem> FoodItems { get; set;}

    }
}
