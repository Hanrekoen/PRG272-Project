using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project272.BusinessLayer
{
    public class SuperHero
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SuperPower { get; set; }
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double Test3 { get; set; }
        public string Rank { get; set; }
        public string ThreatLevel { get; set; }

        
        public SuperHero() { }

        public string SuperHeroLine()
        {
            return $"{ID},{Name},{Age},{SuperPower},{Test1},{Test2},{Test3}";
        }

        public void CalculateRank() // calculate rank and threat level based on average test scores
        {
            double FinalMark = (Test1 + Test2 + Test3) / 3;

            
            if (FinalMark >= 81)
            {
                Rank = "S-Rank";
                ThreatLevel = "Finals Week (threat to the entire academy)";
            }
            else if (FinalMark >= 61)
            {
                Rank = "A-Rank";
                ThreatLevel = "Midterm Madness (threat to a department)";
            }
            else if (FinalMark >= 41)
            {
                Rank = "B-Rank";
                ThreatLevel = "Group Project Gone Wrong (threat to a study group)";
            }
            else
            {
                Rank = "C-Rank";
                ThreatLevel = "Pop Quiz (potential threat to an individual student)";
            }

        }

        public string ToRecordLine() //Add all properties together in a line for the text file with commas for spliting
        {  
            return ID + "," + Name + "," + Age + "," + SuperPower + "," + Test1 + "," + Test2 + "," + Test3 + "," + 
                Rank + "," + ThreatLevel;
            
        }

        public static SuperHero FromRecordLine(string recordLine) // Split the line from the text file into properties
        {
            if (string.IsNullOrWhiteSpace(recordLine)) return null;

            string[] parts = recordLine.Split(',');
            if (parts.Length < 9) return null;

            SuperHero h = new SuperHero();
            h.ID = parts[0];
            h.Name = parts[1];
            h.Age = Convert.ToInt32(parts[2]);
            h.SuperPower = parts[3];
            h.Test1 = double.Parse(parts[4]);
            h.Test2 = double.Parse(parts[5]);
            h.Test3 = double.Parse(parts[6]);
            h.Rank = parts[7];
            h.ThreatLevel = parts[8];

            return h;
        }

        public void Reset()
        {
            ID = string.Empty;
            Name = string.Empty;
            Age = 0;
            SuperPower = string.Empty;
            Test1 = 0;
            Test2 = 0;
            Test3 = 0;
            Rank = string.Empty;
            ThreatLevel = string.Empty;
        }
    }
}

