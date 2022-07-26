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

namespace TOKI.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddFoods();
            UpdateComboBox();
            UpdateDailyReport();
            cbFoodCategory.SelectedIndex = 0;
            ShowCalOfDay();
            cbMealType.SelectedIndex = 0;
            UpdateDgvFoods();


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxPhoto.ImageLocation = ofd.FileName;
            }
        }

        private byte[] ConvertFiltoByte(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                Food food = new Food();
                food.Name = txtFoodName.Text;
                food.Calories = Convert.ToDouble(nudCal.Value);
                food.CategoryName = cbFoodCategory.SelectedItem.ToString();
                food.FoodImage = ConvertFiltoByte(this.pictureBoxPhoto.ImageLocation);
                db.Foods.Add(food);
                db.SaveChanges();
                MessageBox.Show("The Food Added successfully!");
                UpdateDgvFoods();
                listView1.Items.Clear();
                AddFoods();
            }
            catch
            {
                MessageBox.Show("Can not add new photo");
            }
        }
        private Image ConvertBytetoImage(byte[] photo)
        {
            Image newImage;
            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;

        }

        private void AddFoods()
        {
            Context db = new Context();

            var foods = db.Foods.ToList();
            int i = 1;
            ImageList images = new ImageList();
            images.ColorDepth = ColorDepth.Depth32Bit;
            foreach (var food in foods)
            {

                var img = ConvertBytetoImage(food.FoodImage);
                images.Images.Add(i.ToString(), img);
                listView1.LargeImageList = images;
                var lvi = new ListViewItem(food.Name+" - "+food.Calories+" Cal");
                lvi.ImageKey = i.ToString();
                lvi.Tag = i;
                listView1.Items.Add(lvi);
                i++;
                listView1.LargeImageList.ImageSize = new System.Drawing.Size(120, 120);
            }

        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            FoodCategory foodCategory = new FoodCategory();
            foodCategory.Name = txtAddCategory.Text;
            db.FoodCategories.Add(foodCategory);
            db.SaveChanges();
            UpdateComboBox();

        }

        private void UpdateComboBox()
        {
            Context db = new Context();
            var ctgry = db.FoodCategories.ToList();
            var mealtype = db.MealTypes.ToList();
            foreach (var fc in ctgry)
            {
                if (cbFoodCategory.Items.Contains(fc.Name))
                {

                }
                else
                {
                    cbFoodCategory.Items.Add(fc.Name);

                }
            }
            foreach (var mt in mealtype)
            {
                if (cbMealType.Items.Contains(mt.Name))
                {

                }
                else
                {
                    cbMealType.Items.Add(mt.Name);

                }
            }
        }
        private void UpdateDgvFoods()
        {
            Context db = new Context();
            dgvFoods.DataSource = db.Foods.ToList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Context db = new Context();
            var lvi = listView1.SelectedItems[0];
            int foodId = (int)lvi.Tag;
            Food food = db.Foods.FirstOrDefault(x => x.Id == foodId);
            Report report = new Report();
            report.FoodName = food.Name;
            report.UserName = "User";
            report.CategoryName = food.CategoryName;
            report.MealType = cbMealType.SelectedItem.ToString();
            report.Date = DateTime.Now;
            report.Portion = Convert.ToInt32(nudPortion.Value);
            report.FoodCal = food.Calories * Convert.ToInt32(nudPortion.Value);
            db.Reports.Add(report);
            db.SaveChanges();
            MessageBox.Show("The Food Added Succesfully!");
            UpdateDailyReport();
        }

        private void UpdateDailyReport()
        {
            Context db = new Context();
            var reports = db.Reports.ToList();
            dgvDailyReport.DataSource = reports;
            double SumMeal = 0;
            double SumSnack = 0;
            double SumDrink = 0;
            double SumOther = 0;

            foreach (var item in reports)
            {
                if (item.CategoryName=="Meal")
                {
                    SumMeal += item.FoodCal;
                }
                else if (item.CategoryName == "Snack")
                {
                    SumSnack += item.FoodCal;
                }
                
                else if (item.CategoryName == "Drink")
                {
                    SumDrink += item.FoodCal;
                }
                else
                {
                    SumOther += item.FoodCal;
                }
            }
            btnMealCal.Text = SumMeal.ToString()+" Cal";
            btnSnackCal.Text = SumSnack.ToString() + " Cal";
            btnDrinkCal.Text = SumDrink.ToString() + " Cal";
            btnOther.Text = SumOther.ToString() + " Cal";
        }

        private void ShowCalOfDay()
        {
            Context db = new Context();
            int sumofCal = Convert.ToInt32(db.Reports.Sum(x=> x.FoodCal));
            var list = db.Reports.ToList();
            double sum = 0;
            foreach (var item in list)
            {
                sum += item.FoodCal;
            }
            pnlCal.Height = (int)(pnlCalSum.Height * (sum / 2100));
            txtDailyCal.Text = sum.ToString()+ " Cal";
            int percent = (int)((sum / 2100) * 100);
            lblPercent.Text = percent.ToString() + "%";

            if (sum<2100)
            {
                txtNote.Text =("The amount of calories you need to take is " + (2100-sum)+" Cal");
            }
            if (sum>2100)
            {
                txtNote.Text = ("You have exceeded the amount of calories you need to take by "+(sum-2100)+ " Cal");
            }
            if (sum==2100)
            {
                txtNote.Text = ("You have reached the amount of calories you need to take.");
            }
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageDaily);
        }

        private void btnAddQuickFood_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageAddQuickFood);
        }

        private void btnCreateFood_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageCreateFood);
        }

        private void btnComparativeReport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageComparativeReport);
        }

        private void btnFoodSortReport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageFoodSortReport);
        }
    }
}
