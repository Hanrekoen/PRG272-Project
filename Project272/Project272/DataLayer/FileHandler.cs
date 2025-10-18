using Project272.BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project272.DataLayer
{
    public class FileHandler
    {
        private readonly string datafile = "superheroes.txt";//set the data file name
        private readonly string SummaryFile = "summary.txt"; // set the summary file name

        public List<SuperHero> LoadAll() // Method to load all superheroes from the data file
        {
            
            List<SuperHero> heroes = new List<SuperHero>();

            if (!File.Exists(datafile))// Check if the data file exists
            {
                FileStream createfile = new FileStream(datafile, FileMode.Create);
                createfile.Close();
                // If the file doesn't exist, return an empty list
                return heroes;
            }

            FileStream fs = new FileStream(datafile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                SuperHero S = SuperHero.FromRecordLine(line);
                if (S != null)
                {
                    heroes.Add(S);
                }
            }
            sr.Close();
            fs.Close();

            return heroes;
        }


        
        public void SaveAll(List<SuperHero> heroes) // Method to save all superheroes to the data file
        {
            string filename = datafile;

            FileStream fs = new FileStream(datafile, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach(SuperHero S in heroes)
            {
                sw.WriteLine(S.ToRecordLine());
            }
            sw.Close();
            fs.Close();
        }

        public void Append(SuperHero S) // Method to add a new superhero to the data file
        {
            string filename = datafile;

            FileStream fs = new FileStream(datafile, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(S.ToRecordLine());
            
            sw.Close();
            fs.Close();
        }

        public void SaveSummary(string summary)// Method to save the summary report to the summary file using create to overwrite existing file
        {
            string filename = SummaryFile;

            FileStream fs = new FileStream(SummaryFile, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(summary);
            
            sw.Close();
            fs.Close();
        }
    }
}

