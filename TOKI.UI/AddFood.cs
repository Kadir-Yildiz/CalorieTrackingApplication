using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKI.UI
{
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            Form1 f = new Form1();
            var lvi = f.listView1.SelectedItems[0];
            int foodId = (int)lvi.Tag;
            Food food = db.Foods.FirstOrDefault(x=>x.Id==foodId);
            Report report = new Report();
            report.FoodName = food.Name;
            report.UserName = "User";
            report.CategoryName = food.CategoryName;
            report.MealType = cbMealType.SelectedItem.ToString();
            report.Date = DateTime.Now;
            report.Portion = Convert.ToInt32(nudPortion.Value);
            db.Reports.Add(report);
            db.SaveChanges();
            MessageBox.Show("The Food Added Succesfully!");
            f.dgvDailyReport.DataSource = db.Reports.ToList();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            Context db = new Context();
            Form1 f = new Form1();
            var lvi = f.listView1.SelectedItems[0];
            int foodId = (int)lvi.Tag;
            Food food = db.Foods.FirstOrDefault(x => x.Id == foodId);
            txtFoodName.Text = food.Name;
        }
    }
}
