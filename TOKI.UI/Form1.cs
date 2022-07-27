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
        AppUser appUser;
        public Form1(AppUser user)
        {
            InitializeComponent();
            appUser = user;

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
            AddSample();
            cbMealTypeReport.Text = "All";
            cbFoodCategoryReport.Text = "All";
            FoodSortReport();


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

                if (pictureBoxPhoto.Image == null)
                {

                }
                else
                {
                    food.FoodImage = ConvertFiltoByte(this.pictureBoxPhoto.ImageLocation);
                }
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
                var lvi = new ListViewItem(food.Name + " - " + food.Calories + " Cal");
                if (food.FoodImage == null)
                {
                    var imge = Properties.Resources.defaultfood;
                    images.Images.Add(i.ToString(), imge);
                    lvi.ImageKey = i.ToString();
                    lvi.Tag = i;
                    listView1.Items.Add(lvi);
                }
                else
                {
                    var img = ConvertBytetoImage(food.FoodImage);
                    images.Images.Add(i.ToString(), img);
                    lvi.ImageKey = i.ToString();
                    lvi.Tag = i;
                    listView1.Items.Add(lvi);
                }
                listView1.LargeImageList = images;
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
            foreach (var fc in ctgry)
            {
                if (cbFoodCategoryReport.Items.Contains(fc.Name))
                {

                }
                else
                {
                    cbFoodCategoryReport.Items.Add(fc.Name);

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
            foreach (var mt in mealtype)
            {
                if (cbMealTypeReport.Items.Contains(mt.Name))
                {

                }
                else
                {
                    cbMealTypeReport.Items.Add(mt.Name);

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
            report.UserName = appUser.UserName;
            report.FullName = appUser.FirstName + " " + appUser.LastName;
            report.CategoryName = food.CategoryName;
            report.MealType = cbMealType.SelectedItem.ToString();
            report.Date = DateTime.Now;
            report.Portion = Convert.ToInt32(nudPortion.Value);
            report.FoodCal = food.Calories * Convert.ToInt32(nudPortion.Value);
            db.Reports.Add(report);
            db.SaveChanges();
            MessageBox.Show("The Food Added Succesfully!");
            UpdateDailyReport();
            ShowCalOfDay();

        }

        private void UpdateDailyReport()
        {
            Context db = new Context();
            var reports = db.Reports.Where(r => r.Date >= DateTime.Today)
                .Select(x => new
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    FoodName = x.FoodName,
                    Portion = x.Portion,
                    Calories = x.FoodCal,
                    CategoryName = x.CategoryName,
                    MealType = x.MealType,
                    Date = x.Date
                })
                .ToList();
            dgvDailyReport.DataSource = reports;
            double SumMeal = 0;
            double SumSnack = 0;
            double SumDrink = 0;
            double SumOther = 0;

            foreach (var item in reports)
            {
                if (item.CategoryName == "Meal")
                {
                    SumMeal += item.Calories;
                }
                else if (item.CategoryName == "Snack")
                {
                    SumSnack += item.Calories;
                }

                else if (item.CategoryName == "Drink")
                {
                    SumDrink += item.Calories;
                }
                else
                {
                    SumOther += item.Calories;
                }
            }
            btnMealCal.Text = SumMeal.ToString() + " Cal";
            btnSnackCal.Text = SumSnack.ToString() + " Cal";
            btnDrinkCal.Text = SumDrink.ToString() + " Cal";
            btnOther.Text = SumOther.ToString() + " Cal";
        }

        private void ShowCalOfDay()
        {
            Context db = new Context();
            int sumofCal = Convert.ToInt32(db.Reports.Where(r => r.Date >= DateTime.Today).Sum(x => x.FoodCal));
            var list = db.Reports.Where(r => r.Date >= DateTime.Today).ToList();
            double sum = 0;
            foreach (var item in list)
            {
                sum += item.FoodCal;
            }
            pnlCal.Height = (int)(pnlCalSum.Height * (sum / 2100));
            txtDailyCal.Text = sum.ToString() + " Cal";
            int percent = (int)((sum / 2100) * 100);
            lblPercent.Text = percent.ToString() + "%";

            if (sum < 2100)
            {
                txtNote.Text = ("The amount of calories you need to take is " + (2100 - sum) + " Cal");
            }
            if (sum > 2100)
            {
                txtNote.Text = ("You have exceeded the amount of calories you need to take by " + (sum - 2100) + " Cal");
            }
            if (sum == 2100)
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            if (dgvDailyReport.Rows.Count > 0)
            {

                int Id = Convert.ToInt32(dgvDailyReport.CurrentRow.Cells["Id"].Value.ToString());
                DialogResult onay = MessageBox.Show("Are you sure you want to delete this item?", "Deleting Operation", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var report = db.Reports.Find(Id);
                    db.Reports.Remove(report);
                    db.SaveChanges();
                    MessageBox.Show("The Item is Deleted Succesfully!");
                    UpdateDailyReport();
                    ShowCalOfDay();
                }
            }
        }

        private void AddSample()
        {
            Context db = new Context();
            Food food = new Food();
            food.Name = "Pasta";
            food.Calories = 120;
            food.CategoryName = "Meal";
            if (db.Foods.Any(x => x.Name == "Pasta"))
            {

            }
            else
            {
                db.Foods.Add(food);
                db.SaveChanges();
            }
            FoodCategory fc = new FoodCategory();
            //fc.Name=""
            if (db.MealTypes.Count() == 0)
            {
                db.MealTypes.Add(new MealType { Name = "Breakfast" });
                db.MealTypes.Add(new MealType { Name = "Lunch" });
                db.MealTypes.Add(new MealType { Name = "Snack" });
                db.MealTypes.Add(new MealType { Name = "Dinner" });
            }



        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Context db = new Context();

            DateTime startDate, endDate;
            string mt = cbMealTypeReport.Text;
            string fc = cbFoodCategoryReport.Text;

            
            
            if (rbDaily.Checked)
            {
                startDate = Convert.ToDateTime(dtpStartDate.Value.ToShortDateString());
                endDate = Convert.ToDateTime(dtpStartDate.Value.AddDays(1).ToShortDateString());
                if (mt != "All" && fc == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.MealType == mt).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (fc != "All" && mt == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.CategoryName == fc).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (mt != "All" && fc != "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.CategoryName == fc && r.MealType == mt).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (mt == "All" && fc == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                

            }
            else if (rbWeekly.Checked)
            {
                startDate = Convert.ToDateTime(dtpStartDate.Value.ToShortDateString());
                endDate = Convert.ToDateTime(dtpStartDate.Value.AddDays(7).ToShortDateString());
                if (mt != "All" && fc == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.MealType == mt).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (fc != "All" && mt == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.CategoryName == fc).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (mt != "All" && fc != "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.CategoryName == fc && r.MealType == mt).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (mt == "All" && fc == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate).ToList();
                    dgvComparativeReport.DataSource = report;
                }
            }
            else if (rbMonthly.Checked)
            {
                startDate = Convert.ToDateTime(dtpStartDate.Value.ToShortDateString());
                endDate = Convert.ToDateTime(dtpStartDate.Value.AddMonths(1).ToShortDateString());

                if (mt != "All" && fc == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.MealType == mt).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (fc != "All" && mt == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.CategoryName == fc).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (mt != "All" && fc != "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate && r.CategoryName == fc && r.MealType == mt).ToList();
                    dgvComparativeReport.DataSource = report;
                }
                if (mt == "All" && fc == "All")
                {
                    var report = db.Reports.Where(r => r.Date >= startDate && r.Date <= endDate).ToList();
                    dgvComparativeReport.DataSource = report;
                }
            }
        }

        private void FoodSortReport()
        {
            Context db = new Context();
            var foods = db.Reports.Select(x => new
            {
                Name = x.FoodName,
                Portion = x.Portion,
                Calories = x.FoodCal,
                MealType = x.MealType,
            }).ToList();


            var breakfast = foods.GroupBy(f => new
            {
                Name = f.Name,
            }).Select(g => new
            {
                Name = g.Key.Name,
                Calories = g.Where(x => x.MealType == "Breakfast").Select(x => x.Calories).Sum(),
                BreakfastPortion = g.Where(x => x.MealType == "Breakfast").Select(x => x.Portion).Sum(),
            }).OrderByDescending(f => f.BreakfastPortion);

            dgvBreakfast.DataSource = breakfast.ToList();




            var lunch = foods.GroupBy(f => new
            {
                Name = f.Name,
            }).Select(g => new
            {
                Name = g.Key.Name,
                Calories = g.Where(x => x.MealType == "Lunch").Select(x => x.Calories).Sum(),
                LunchPortion = g.Where(x => x.MealType == "Lunch").Select(x => x.Portion).Sum(),
            }).OrderByDescending(f => f.LunchPortion);

            dgvLunch.DataSource = lunch.ToList();

            var dinner = foods.GroupBy(f => new
            {
                Name = f.Name,
            }).Select(g => new
            {
                Name = g.Key.Name,
                Calories = g.Where(x => x.MealType == "Dinner").Select(x => x.Calories).Sum(),
                DinnerPortion = g.Where(x => x.MealType == "Dinner").Select(x => x.Portion).Sum(),
            }).OrderByDescending(f => f.DinnerPortion);

            dgvDinner.DataSource = dinner.ToList();




            var snack = foods.GroupBy(f => new
            {
                Name = f.Name,
            }).Select(g => new
            {
                Name = g.Key.Name,
                Calories = g.Where(x => x.MealType == "Snack").Select(x => x.Calories).Sum(),
                SnackPortion = g.Where(x => x.MealType == "Snack").Select(x => x.Portion).Sum(),
            }).OrderByDescending(f => f.SnackPortion);

            dgvSnack.DataSource = snack.ToList();










        }
    }
}
