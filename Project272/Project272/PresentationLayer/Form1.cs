using Project272.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project272.DataLayer;
using Project272.PresentationLayer;

namespace Project272
{
    public partial class Form1 : Form
    {
        private BindingList<SuperHero> heroes = new BindingList<SuperHero>();
        private HeroManager heroManager = new HeroManager();

        
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = heroes;

        }
        private void LoadData()
        {
            heroes.Clear();
            foreach (var hero in heroManager.GetAllHeroes())
            {
                heroes.Add(hero);
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Add Button
        {
            try
            {

                if (!double.TryParse(Test1textBox.Text, out double t1) || t1 < 0 || t1 > 100 ||
                    !double.TryParse(Test2textBox.Text, out double t2) || t2 < 0 || t2 > 100 ||
                    !double.TryParse(Test3textBox.Text, out double t3) || t3 < 0 || t3 > 100 )
                {
                    MessageBox.Show("All test scores must be between 0 and 100.");
                    return;
                }

                var newHero = new SuperHero
                {
                    ID = IDtextBox.Text,
                    Name = NametextBox.Text,
                    Age = int.Parse(AgetextBox.Text),
                    SuperPower = SPtextBox.Text,
                    Test1 = double.Parse(Test1textBox.Text),
                    Test2 = double.Parse(Test2textBox.Text),
                    Test3 = double.Parse(Test3textBox.Text)
                };
                heroManager.AddHero(newHero, heroes.ToList());
                heroes.Add(newHero);
                btnClear.PerformClick();
                //UpdateSummaryLabels();
                MessageBox.Show("Hero added successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding hero: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            NametextBox.Clear();
            AgetextBox.Clear();
            SPtextBox.Clear();
            Test1textBox.Clear();
            Test2textBox.Clear();
            Test3textBox.Clear();

        }

        private void Test1textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            heroManager.UpdateHeroes(heroes.ToList());
            MessageBox.Show("Heroes updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedHero = dataGridView1.SelectedRows[0].DataBoundItem as SuperHero;
                if (selectedHero != null)
                {
                    heroManager.DeleteHero(selectedHero, heroes.ToList());
                    heroes.Remove(selectedHero);
                    MessageBox.Show("Hero deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a hero to delete.");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var ReportText = heroManager.GenerateSummary(heroes.ToList());
            MessageBox.Show(ReportText, "Hero Summary Report");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return;

            var hero = dataGridView1.Rows[e.RowIndex].DataBoundItem as Project272.BusinessLayer.SuperHero;
            if (hero == null) return;

            IDtextBox.Text = hero.ID;
            NametextBox.Text = hero.Name;
            AgetextBox.Text = hero.Age.ToString();
            SPtextBox.Text = hero.SuperPower;
            Test1textBox.Text = hero.Test1.ToString();
            Test2textBox.Text = hero.Test2.ToString();
            Test3textBox.Text = hero.Test3.ToString();


        }
    }
}
