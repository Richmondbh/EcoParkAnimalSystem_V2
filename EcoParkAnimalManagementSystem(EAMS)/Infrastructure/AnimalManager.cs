using EcoParkAnimalManagementSystem_EAMS_.AnimalGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkAnimalManagementSystem_EAMS_.Infrastructure
{
    public class AnimalManager : ListManager<Animal>
    {
        private static int startID = 1;

        public AnimalManager() : base()
        {
        }

        public void SetNewID(Animal animal)
        {
            if (animal == null)
            {
                return;
            }

            string categoryPrefix = GetCategoryPrefix(animal.Category);
            animal.Id = categoryPrefix + startID.ToString();
            startID++;
        }

        private string GetCategoryPrefix(CategoryType category)
        {
            switch (category)
            {
                case CategoryType.Mammal:
                    return "Mammal";
                case CategoryType.Reptile:
                    return "Reptile";
                case CategoryType.Bird:
                    return "Bird";
                case CategoryType.Insect:
                    return "Insect";
                default:
                    return "No category";
            }
        }

        public string[] ToStringSummaryAllAnimals()
        {
            string[] summaryArray = new string[Count];

            for (int i = 0; i < Count; i++)
            {
                Animal animal = GetAt(i);
                if (animal != null)
                {
                    summaryArray[i] = animal.ToStringSummary();
                }
            }

            return summaryArray;
        }

        public string GetDetailedAnimalInfo(int index)
        {
            if (!CheckIndex(index))
            {
                return string.Empty;
            }

            Animal animal = GetAt(index);
            if (animal == null)
            {
                return string.Empty;
            }

            string output = animal.ToString();
            output += "\n----- ANIMAL LIFESPAN ---\n";
            output += $"Average Animal Lifespan: {animal.GetAverageLifeSpan()} years\n";

            output += "\n---FOOD REQUIREMENTS ---\n";
            Dictionary<string, string> foodSchedule = animal.DailyFoodRequirement();
            foreach (KeyValuePair<string, string> meal in foodSchedule)
            {
                output += $"{meal.Key}: {meal.Value}\n";
            }

            output += "\n--- UPCOMING EVENTS ---\n";
            Queue<string> events = animal.GetUpcomingEvents();
            int eventNumber = 1;
            while (events.Count > 0)
            {
                output += $"{eventNumber}. {events.Dequeue()}\n";
                eventNumber++;
            }

            return output;
        }
    }

}

