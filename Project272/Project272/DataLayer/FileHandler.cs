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
        private readonly string datafile = "superheroes.txt";
        private readonly string SummaryFile = "summary.txt";

        public List<SuperHero> LoadAll()
        {
            
            List<SuperHero> heroes = new List<SuperHero>();

            if (!File.Exists(datafile))
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


        
        public void SaveAll(List<SuperHero> heroes)
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

        public void Append(SuperHero S)
        {
            string filename = datafile;

            FileStream fs = new FileStream(datafile, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(S.ToRecordLine());
            
            sw.Close();
            fs.Close();
        }

        public void SaveSummary(string summary)
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
