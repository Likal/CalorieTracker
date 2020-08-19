using System;
using System.Collections.Generic;


namespace CalorieTracker.Models
{
    public class DailyFoodIntake
    {
        public Guid Id { get; set; }

        public Guid FoodItemId { get; set; }

        public DateTime FoodItemAdded { get; set; }

        public int DailyCalorieAllowance { get; set; }

        public int TotalCalorieRemaining { get; set; }

        public int TotalCalorieConsumed { get; set; }

        public string SearchFoodItem { get; set; }

        public bool IsArchived { get; set; }

        




      

    }
}
