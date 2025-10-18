using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Project272.DataLayer;
using Project272.BusinessLayer;

namespace Project272.BusinessLayer
{
    public class HeroManager
    {
        private readonly FileHandler fileHandler;

        public HeroManager()//Added Hero Manager as constructor
        {
            fileHandler = new FileHandler();
        }

        public List<SuperHero> GetAllHeroes() // Method to get all heroes
        {
            return fileHandler.LoadAll();
        }

        public void AddHero(SuperHero hero, List<SuperHero> currentHeroes)// Method to add a new hero and check if hero id already exists
        {
            if (currentHeroes.Any(h => h.ID.Equals(hero.ID, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("A hero with the same ID already exists.");
            }

            // Only reached if no duplicate
            hero.CalculateRank();
            fileHandler.Append(hero);

        }

        public void UpdateHeroes(List<SuperHero> heroes)// Method to update heroes and recalculate their ranks
        {
            foreach(var hero in heroes)
            {
                hero.CalculateRank();
                
            }
            fileHandler.SaveAll(heroes);
        }

        public void DeleteHero(SuperHero superHero, List<SuperHero> heroes)// Method to delete a hero
        {
            heroes.Remove(superHero);
            fileHandler.SaveAll(heroes);
        }

        public string GenerateSummary(List<SuperHero> heroes)// Method to generate summary report in a text file
        {
            int total = heroes.Count;
            double averageAge = 0;
            double averageTestScore = 0;
            int s = 0;
            int a = 0;
            int b = 0;
            int c = 0;



            if (total > 0)// ensures the total of heros is greater than 0 
            {
                double totalAge = 0;
                foreach (var hero in heroes) // calculates average age of heroes
                {
                    totalAge += hero.Age;
                    
                }
                averageAge = totalAge / total;
            }else
            {
                averageAge = 0;
            }

            if (total > 0)// Calculate the average test score of heroes
            {
                double totalTestScore = 0;
                foreach (var hero in heroes)
                {
                    totalTestScore += (hero.Test1 + hero.Test2 + hero.Test3) /3;
                }
                averageTestScore = Math.Round(totalTestScore / total, 2);
            }
            else
            {
                averageTestScore = 0;
            }

            foreach (var hero in heroes)// Count the number of heroes in each rank
            {
                switch (hero.Rank)
                {
                    case "S-Rank":
                        s++;
                        break;
                    case "A-Rank":
                        a++;
                        break;
                    case "B-Rank":
                        b++;
                        break;
                    case "C-Rank":
                        c++;
                        break;
                    default:
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();// Build the actual summary report string using stringbuilder
            sb.AppendLine("Superhero Summary Report");
            sb.AppendLine("-----------------------------------");
            sb.AppendLine("Created on: " + DateTime.Now);
            sb.AppendLine($"Total Superheroes: {total}");
            sb.AppendLine($"Average Age: {averageAge.ToString()}");
            sb.AppendLine($"Average Test Score: {averageTestScore.ToString()}");
            sb.AppendLine("S Rank: " + s);
            sb.AppendLine("A Rank: " + a);
            sb.AppendLine("B Rank: " + b);
            sb.AppendLine("C Rank: " + c);

            fileHandler.SaveSummary(sb.ToString());
            return sb.ToString();
        }

    }
}


