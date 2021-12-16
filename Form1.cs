/** 
 * Author1:  Philip Rönnmark 990513-4392 (phrinn-1@student.ltu.se) 
 * Course:   L0002B
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sales
{
    public partial class Form1 : Form
    {
        private BonusSystem bonusSystem = new BonusSystem();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When add button clicked add person to people list.
        /// </summary>
        private void createPerson()
        {
            Person p = new Person(txtName.Text, txtPnr.Text, txtDistrict.Text, int.Parse(txtNumOfArticles.Text));
            bonusSystem.AddPerson(p);
        }

        /// <summary>
        /// Create person and clear input fields, and display output to listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPnr.Text != "" && txtDistrict.Text != "" && int.TryParse(txtNumOfArticles.Text, out int result))
            {
                createPerson();
                rtxtPeople.Clear();
                rtxtPeople.Text = bonusSystem.display();
            }
            else
            {
                MessageBox.Show("Please enter correct values");
            }

        }

        /// <summary>
        /// Writes to file located Sales\bin\Debug named SalesBonuses.txt
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public async Task ExampleAsync(string s)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SalesBonuses.txt");
            File.WriteAllText(path, s);
        }

        /// <summary>
        /// Event handler for print button, writes current data to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string s = bonusSystem.display();
            ExampleAsync(s);
            MessageBox.Show("Written to file SalesBonuses.txt");



        }
    }
}
