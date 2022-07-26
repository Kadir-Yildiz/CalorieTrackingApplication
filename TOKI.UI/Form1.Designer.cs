namespace TOKI.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDaily = new System.Windows.Forms.TabPage();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnDrinkCal = new System.Windows.Forms.Button();
            this.btnSnackCal = new System.Windows.Forms.Button();
            this.btnMealCal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCal = new System.Windows.Forms.Panel();
            this.pnlCalSum = new System.Windows.Forms.Panel();
            this.tabPageCreateFood = new System.Windows.Forms.TabPage();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.nudCal = new System.Windows.Forms.NumericUpDown();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tabPageComparativeReport = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageAddQuickFood = new System.Windows.Forms.TabPage();
            this.nudPortion = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMealType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnFoodSortReport = new System.Windows.Forms.Button();
            this.btnComparativeReport = new System.Windows.Forms.Button();
            this.btnAddQuickFood = new System.Windows.Forms.Button();
            this.btnCreateFood = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDailyCal = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tabPageFoodSortReport = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            this.pnlCalSum.SuspendLayout();
            this.tabPageCreateFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tabPageComparativeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageAddQuickFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDaily);
            this.tabControl1.Controls.Add(this.tabPageCreateFood);
            this.tabControl1.Controls.Add(this.tabPageComparativeReport);
            this.tabControl1.Controls.Add(this.tabPageAddQuickFood);
            this.tabControl1.Controls.Add(this.tabPageFoodSortReport);
            this.tabControl1.Location = new System.Drawing.Point(302, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 737);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPageDaily
            // 
            this.tabPageDaily.Controls.Add(this.txtDailyCal);
            this.tabPageDaily.Controls.Add(this.textBox2);
            this.tabPageDaily.Controls.Add(this.btnOther);
            this.tabPageDaily.Controls.Add(this.label16);
            this.tabPageDaily.Controls.Add(this.dgvDailyReport);
            this.tabPageDaily.Controls.Add(this.txtNote);
            this.tabPageDaily.Controls.Add(this.btnDrinkCal);
            this.tabPageDaily.Controls.Add(this.btnSnackCal);
            this.tabPageDaily.Controls.Add(this.btnMealCal);
            this.tabPageDaily.Controls.Add(this.label4);
            this.tabPageDaily.Controls.Add(this.label2);
            this.tabPageDaily.Controls.Add(this.label1);
            this.tabPageDaily.Controls.Add(this.pnlCalSum);
            this.tabPageDaily.Location = new System.Drawing.Point(4, 25);
            this.tabPageDaily.Name = "tabPageDaily";
            this.tabPageDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDaily.Size = new System.Drawing.Size(1087, 708);
            this.tabPageDaily.TabIndex = 0;
            this.tabPageDaily.Text = "DailyReport";
            this.tabPageDaily.UseVisualStyleBackColor = true;
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDailyReport.Location = new System.Drawing.Point(3, 259);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowHeadersWidth = 51;
            this.dgvDailyReport.RowTemplate.Height = 24;
            this.dgvDailyReport.Size = new System.Drawing.Size(1081, 446);
            this.dgvDailyReport.TabIndex = 30;
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNote.Location = new System.Drawing.Point(294, 184);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(710, 28);
            this.txtNote.TabIndex = 29;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDrinkCal
            // 
            this.btnDrinkCal.Enabled = false;
            this.btnDrinkCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrinkCal.Location = new System.Drawing.Point(688, 86);
            this.btnDrinkCal.Name = "btnDrinkCal";
            this.btnDrinkCal.Size = new System.Drawing.Size(134, 52);
            this.btnDrinkCal.TabIndex = 28;
            this.btnDrinkCal.Text = "0 cal";
            this.btnDrinkCal.UseVisualStyleBackColor = true;
            // 
            // btnSnackCal
            // 
            this.btnSnackCal.Enabled = false;
            this.btnSnackCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSnackCal.Location = new System.Drawing.Point(491, 86);
            this.btnSnackCal.Name = "btnSnackCal";
            this.btnSnackCal.Size = new System.Drawing.Size(134, 52);
            this.btnSnackCal.TabIndex = 26;
            this.btnSnackCal.Text = "0 cal";
            this.btnSnackCal.UseVisualStyleBackColor = true;
            // 
            // btnMealCal
            // 
            this.btnMealCal.Enabled = false;
            this.btnMealCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMealCal.Location = new System.Drawing.Point(294, 86);
            this.btnMealCal.Name = "btnMealCal";
            this.btnMealCal.Size = new System.Drawing.Size(134, 52);
            this.btnMealCal.TabIndex = 25;
            this.btnMealCal.Text = "0 cal";
            this.btnMealCal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(712, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "DRINK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(502, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "SNACK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(321, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "MEAL";
            // 
            // pnlCal
            // 
            this.pnlCal.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlCal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCal.Location = new System.Drawing.Point(0, 170);
            this.pnlCal.Name = "pnlCal";
            this.pnlCal.Size = new System.Drawing.Size(120, 30);
            this.pnlCal.TabIndex = 19;
            // 
            // pnlCalSum
            // 
            this.pnlCalSum.BackColor = System.Drawing.Color.LightGray;
            this.pnlCalSum.Controls.Add(this.lblPercent);
            this.pnlCalSum.Controls.Add(this.pnlCal);
            this.pnlCalSum.Location = new System.Drawing.Point(90, 14);
            this.pnlCalSum.Name = "pnlCalSum";
            this.pnlCalSum.Size = new System.Drawing.Size(120, 200);
            this.pnlCalSum.TabIndex = 20;
            // 
            // tabPageCreateFood
            // 
            this.tabPageCreateFood.Controls.Add(this.dgvFoods);
            this.tabPageCreateFood.Controls.Add(this.btnCategorySave);
            this.tabPageCreateFood.Controls.Add(this.label13);
            this.tabPageCreateFood.Controls.Add(this.txtAddCategory);
            this.tabPageCreateFood.Controls.Add(this.nudCal);
            this.tabPageCreateFood.Controls.Add(this.cbFoodCategory);
            this.tabPageCreateFood.Controls.Add(this.label11);
            this.tabPageCreateFood.Controls.Add(this.label12);
            this.tabPageCreateFood.Controls.Add(this.label10);
            this.tabPageCreateFood.Controls.Add(this.label9);
            this.tabPageCreateFood.Controls.Add(this.txtFoodName);
            this.tabPageCreateFood.Controls.Add(this.btnSave);
            this.tabPageCreateFood.Controls.Add(this.pictureBoxPhoto);
            this.tabPageCreateFood.Controls.Add(this.btnBrowse);
            this.tabPageCreateFood.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreateFood.Name = "tabPageCreateFood";
            this.tabPageCreateFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateFood.Size = new System.Drawing.Size(1087, 708);
            this.tabPageCreateFood.TabIndex = 1;
            this.tabPageCreateFood.Text = "CreateFood";
            this.tabPageCreateFood.UseVisualStyleBackColor = true;
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFoods.Location = new System.Drawing.Point(3, 230);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.RowHeadersWidth = 51;
            this.dgvFoods.RowTemplate.Height = 24;
            this.dgvFoods.Size = new System.Drawing.Size(1081, 475);
            this.dgvFoods.TabIndex = 27;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategorySave.Location = new System.Drawing.Point(872, 115);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(113, 31);
            this.btnCategorySave.TabIndex = 26;
            this.btnCategorySave.Text = "Save";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(868, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Add Category";
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddCategory.Location = new System.Drawing.Point(837, 78);
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(181, 26);
            this.txtAddCategory.TabIndex = 24;
            // 
            // nudCal
            // 
            this.nudCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudCal.Location = new System.Drawing.Point(50, 141);
            this.nudCal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCal.Name = "nudCal";
            this.nudCal.Size = new System.Drawing.Size(182, 26);
            this.nudCal.TabIndex = 23;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(291, 45);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(182, 28);
            this.cbFoodCategory.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(46, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Calorie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(289, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Food Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(289, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Food Image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(46, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Food Name";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFoodName.Location = new System.Drawing.Point(49, 43);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(181, 26);
            this.txtFoodName.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(551, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(534, 20);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(191, 130);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 12;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.Location = new System.Drawing.Point(337, 141);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 31);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tabPageComparativeReport
            // 
            this.tabPageComparativeReport.Controls.Add(this.label8);
            this.tabPageComparativeReport.Controls.Add(this.label7);
            this.tabPageComparativeReport.Controls.Add(this.comboBox2);
            this.tabPageComparativeReport.Controls.Add(this.comboBox1);
            this.tabPageComparativeReport.Controls.Add(this.button11);
            this.tabPageComparativeReport.Controls.Add(this.label6);
            this.tabPageComparativeReport.Controls.Add(this.label5);
            this.tabPageComparativeReport.Controls.Add(this.dateTimePicker2);
            this.tabPageComparativeReport.Controls.Add(this.radioButton3);
            this.tabPageComparativeReport.Controls.Add(this.radioButton2);
            this.tabPageComparativeReport.Controls.Add(this.radioButton1);
            this.tabPageComparativeReport.Controls.Add(this.dateTimePicker1);
            this.tabPageComparativeReport.Controls.Add(this.dataGridView2);
            this.tabPageComparativeReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageComparativeReport.Name = "tabPageComparativeReport";
            this.tabPageComparativeReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComparativeReport.Size = new System.Drawing.Size(1087, 708);
            this.tabPageComparativeReport.TabIndex = 2;
            this.tabPageComparativeReport.Text = "ComparativeReport";
            this.tabPageComparativeReport.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(210, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Yemek Kategorisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(210, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Öğün";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(215, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 33);
            this.comboBox2.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 33);
            this.comboBox1.TabIndex = 41;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(740, 67);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(162, 49);
            this.button11.TabIndex = 40;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(448, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(448, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(453, 119);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(53, 121);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(131, 29);
            this.radioButton3.TabIndex = 36;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "MONTHLY";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(53, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 29);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "WEEKLY";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(53, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 29);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DAILY";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 202);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1081, 503);
            this.dataGridView2.TabIndex = 32;
            // 
            // tabPageAddQuickFood
            // 
            this.tabPageAddQuickFood.Controls.Add(this.nudPortion);
            this.tabPageAddQuickFood.Controls.Add(this.label14);
            this.tabPageAddQuickFood.Controls.Add(this.cbMealType);
            this.tabPageAddQuickFood.Controls.Add(this.label15);
            this.tabPageAddQuickFood.Controls.Add(this.listView1);
            this.tabPageAddQuickFood.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddQuickFood.Name = "tabPageAddQuickFood";
            this.tabPageAddQuickFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddQuickFood.Size = new System.Drawing.Size(1087, 708);
            this.tabPageAddQuickFood.TabIndex = 3;
            this.tabPageAddQuickFood.Text = "AddQuickFood";
            this.tabPageAddQuickFood.UseVisualStyleBackColor = true;
            // 
            // nudPortion
            // 
            this.nudPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPortion.Location = new System.Drawing.Point(333, 30);
            this.nudPortion.Name = "nudPortion";
            this.nudPortion.Size = new System.Drawing.Size(147, 30);
            this.nudPortion.TabIndex = 19;
            this.nudPortion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(516, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Meal Type";
            // 
            // cbMealType
            // 
            this.cbMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMealType.FormattingEnabled = true;
            this.cbMealType.Location = new System.Drawing.Point(627, 29);
            this.cbMealType.Name = "cbMealType";
            this.cbMealType.Size = new System.Drawing.Size(147, 33);
            this.cbMealType.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(254, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Portion";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1081, 623);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // btnFoodSortReport
            // 
            this.btnFoodSortReport.BackColor = System.Drawing.Color.Bisque;
            this.btnFoodSortReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodSortReport.Location = new System.Drawing.Point(12, 610);
            this.btnFoodSortReport.Name = "btnFoodSortReport";
            this.btnFoodSortReport.Size = new System.Drawing.Size(272, 132);
            this.btnFoodSortReport.TabIndex = 50;
            this.btnFoodSortReport.Text = "Food Sort Report";
            this.btnFoodSortReport.UseVisualStyleBackColor = false;
            this.btnFoodSortReport.Click += new System.EventHandler(this.btnFoodSortReport_Click);
            // 
            // btnComparativeReport
            // 
            this.btnComparativeReport.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnComparativeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComparativeReport.Location = new System.Drawing.Point(12, 460);
            this.btnComparativeReport.Name = "btnComparativeReport";
            this.btnComparativeReport.Size = new System.Drawing.Size(272, 132);
            this.btnComparativeReport.TabIndex = 49;
            this.btnComparativeReport.Text = "Comparative Report";
            this.btnComparativeReport.UseVisualStyleBackColor = false;
            this.btnComparativeReport.Click += new System.EventHandler(this.btnComparativeReport_Click);
            // 
            // btnAddQuickFood
            // 
            this.btnAddQuickFood.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddQuickFood.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddQuickFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddQuickFood.Location = new System.Drawing.Point(12, 160);
            this.btnAddQuickFood.Name = "btnAddQuickFood";
            this.btnAddQuickFood.Size = new System.Drawing.Size(272, 132);
            this.btnAddQuickFood.TabIndex = 48;
            this.btnAddQuickFood.Text = "Add Quick Food";
            this.btnAddQuickFood.UseVisualStyleBackColor = false;
            this.btnAddQuickFood.Click += new System.EventHandler(this.btnAddQuickFood_Click);
            // 
            // btnCreateFood
            // 
            this.btnCreateFood.BackColor = System.Drawing.SystemColors.Info;
            this.btnCreateFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateFood.Location = new System.Drawing.Point(12, 310);
            this.btnCreateFood.Name = "btnCreateFood";
            this.btnCreateFood.Size = new System.Drawing.Size(272, 132);
            this.btnCreateFood.TabIndex = 46;
            this.btnCreateFood.Text = "Create Food";
            this.btnCreateFood.UseVisualStyleBackColor = false;
            this.btnCreateFood.Click += new System.EventHandler(this.btnCreateFood_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDailyReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDailyReport.Location = new System.Drawing.Point(12, 15);
            this.btnDailyReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(272, 127);
            this.btnDailyReport.TabIndex = 45;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnOther
            // 
            this.btnOther.Enabled = false;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOther.Location = new System.Drawing.Point(885, 86);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(134, 52);
            this.btnOther.TabIndex = 32;
            this.btnOther.Text = "0 cal";
            this.btnOther.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(909, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 29);
            this.label16.TabIndex = 31;
            this.label16.Text = "OTHER";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(216, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 26);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "2100 Cal";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDailyCal
            // 
            this.txtDailyCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDailyCal.Location = new System.Drawing.Point(9, 188);
            this.txtDailyCal.Name = "txtDailyCal";
            this.txtDailyCal.Size = new System.Drawing.Size(75, 26);
            this.txtDailyCal.TabIndex = 34;
            this.txtDailyCal.Text = "0 Cal";
            this.txtDailyCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPercent.Location = new System.Drawing.Point(34, 83);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(52, 25);
            this.lblPercent.TabIndex = 20;
            this.lblPercent.Text = "%50";
            // 
            // tabPageFoodSortReport
            // 
            this.tabPageFoodSortReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageFoodSortReport.Name = "tabPageFoodSortReport";
            this.tabPageFoodSortReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFoodSortReport.Size = new System.Drawing.Size(1087, 708);
            this.tabPageFoodSortReport.TabIndex = 4;
            this.tabPageFoodSortReport.Text = "FoodSortReport";
            this.tabPageFoodSortReport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 758);
            this.Controls.Add(this.btnFoodSortReport);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnComparativeReport);
            this.Controls.Add(this.btnAddQuickFood);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.btnCreateFood);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDaily.ResumeLayout(false);
            this.tabPageDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            this.pnlCalSum.ResumeLayout(false);
            this.pnlCalSum.PerformLayout();
            this.tabPageCreateFood.ResumeLayout(false);
            this.tabPageCreateFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tabPageComparativeReport.ResumeLayout(false);
            this.tabPageComparativeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageAddQuickFood.ResumeLayout(false);
            this.tabPageAddQuickFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDaily;
        private System.Windows.Forms.TabPage tabPageCreateFood;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnDrinkCal;
        private System.Windows.Forms.Button btnSnackCal;
        private System.Windows.Forms.Button btnMealCal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCal;
        private System.Windows.Forms.Panel pnlCalSum;
        private System.Windows.Forms.TabPage tabPageComparativeReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFoodSortReport;
        private System.Windows.Forms.Button btnComparativeReport;
        private System.Windows.Forms.Button btnAddQuickFood;
        private System.Windows.Forms.Button btnCreateFood;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.NumericUpDown nudCal;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageAddQuickFood;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.DataGridView dgvDailyReport;
        private System.Windows.Forms.NumericUpDown nudPortion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMealType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDailyCal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TabPage tabPageFoodSortReport;
    }
}

