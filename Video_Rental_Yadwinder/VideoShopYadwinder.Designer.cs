namespace Video_Rental_Yadwinder
{
    partial class VideoShopYadwinder
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.allRentedRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.plotTxt = new System.Windows.Forms.TextBox();
            this.outRentedRadioBtn = new System.Windows.Forms.RadioButton();
            this.custFirstNameTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.custLastNameTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentalIDTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.rentalCostTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.movieIDTxt = new System.Windows.Forms.TextBox();
            this.MovieUpdateBtn = new System.Windows.Forms.Button();
            this.MovieDeleteBtn = new System.Windows.Forms.Button();
            this.MovieAddBtn = new System.Windows.Forms.Button();
            this.MovieIssueBtn = new System.Windows.Forms.Button();
            this.MovieReturnBtn = new System.Windows.Forms.Button();
            this.CustomerDeleteBtn = new System.Windows.Forms.Button();
            this.CustomerUpdateBtn = new System.Windows.Forms.Button();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.custIDTxt = new System.Windows.Forms.TextBox();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 233);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(770, 207);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(770, 207);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewRental);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 207);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.Size = new System.Drawing.Size(770, 207);
            this.dataGridViewRental.TabIndex = 0;
            this.dataGridViewRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRental_CellContentClick);
            // 
            // allRentedRadioBtn
            // 
            this.allRentedRadioBtn.AutoSize = true;
            this.allRentedRadioBtn.Location = new System.Drawing.Point(3, 38);
            this.allRentedRadioBtn.Name = "allRentedRadioBtn";
            this.allRentedRadioBtn.Size = new System.Drawing.Size(74, 17);
            this.allRentedRadioBtn.TabIndex = 1;
            this.allRentedRadioBtn.TabStop = true;
            this.allRentedRadioBtn.Text = "All Rented";
            this.allRentedRadioBtn.UseVisualStyleBackColor = true;
            this.allRentedRadioBtn.CheckedChanged += new System.EventHandler(this.allRentedRadioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rented Movies";
            // 
            // plotTxt
            // 
            this.plotTxt.Location = new System.Drawing.Point(462, 338);
            this.plotTxt.Name = "plotTxt";
            this.plotTxt.Size = new System.Drawing.Size(107, 20);
            this.plotTxt.TabIndex = 43;
            // 
            // outRentedRadioBtn
            // 
            this.outRentedRadioBtn.AutoSize = true;
            this.outRentedRadioBtn.Location = new System.Drawing.Point(120, 38);
            this.outRentedRadioBtn.Name = "outRentedRadioBtn";
            this.outRentedRadioBtn.Size = new System.Drawing.Size(80, 17);
            this.outRentedRadioBtn.TabIndex = 2;
            this.outRentedRadioBtn.TabStop = true;
            this.outRentedRadioBtn.Text = "Out Rented";
            this.outRentedRadioBtn.UseVisualStyleBackColor = true;
            this.outRentedRadioBtn.CheckedChanged += new System.EventHandler(this.outRentedRadioBtn_CheckedChanged);
            // 
            // custFirstNameTxt
            // 
            this.custFirstNameTxt.Location = new System.Drawing.Point(91, 298);
            this.custFirstNameTxt.Name = "custFirstNameTxt";
            this.custFirstNameTxt.Size = new System.Drawing.Size(115, 20);
            this.custFirstNameTxt.TabIndex = 42;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(333, 298);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(115, 20);
            this.addressTxt.TabIndex = 41;
            // 
            // custLastNameTxt
            // 
            this.custLastNameTxt.Location = new System.Drawing.Point(212, 298);
            this.custLastNameTxt.Name = "custLastNameTxt";
            this.custLastNameTxt.Size = new System.Drawing.Size(115, 20);
            this.custLastNameTxt.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.allRentedRadioBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.outRentedRadioBtn);
            this.panel1.Location = new System.Drawing.Point(516, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 72);
            this.panel1.TabIndex = 39;
            // 
            // rentalIDTxt
            // 
            this.rentalIDTxt.Location = new System.Drawing.Point(575, 338);
            this.rentalIDTxt.Name = "rentalIDTxt";
            this.rentalIDTxt.Size = new System.Drawing.Size(37, 20);
            this.rentalIDTxt.TabIndex = 38;
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(256, 337);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(95, 20);
            this.genreTxt.TabIndex = 37;
            // 
            // rentalCostTxt
            // 
            this.rentalCostTxt.Location = new System.Drawing.Point(357, 337);
            this.rentalCostTxt.Name = "rentalCostTxt";
            this.rentalCostTxt.Size = new System.Drawing.Size(91, 20);
            this.rentalCostTxt.TabIndex = 36;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(154, 337);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(96, 20);
            this.titleTxt.TabIndex = 35;
            // 
            // movieIDTxt
            // 
            this.movieIDTxt.Location = new System.Drawing.Point(91, 337);
            this.movieIDTxt.Name = "movieIDTxt";
            this.movieIDTxt.Size = new System.Drawing.Size(57, 20);
            this.movieIDTxt.TabIndex = 34;
            // 
            // MovieUpdateBtn
            // 
            this.MovieUpdateBtn.Location = new System.Drawing.Point(91, 387);
            this.MovieUpdateBtn.Name = "MovieUpdateBtn";
            this.MovieUpdateBtn.Size = new System.Drawing.Size(100, 62);
            this.MovieUpdateBtn.TabIndex = 33;
            this.MovieUpdateBtn.Text = "Update Movie";
            this.MovieUpdateBtn.UseVisualStyleBackColor = true;
            this.MovieUpdateBtn.Click += new System.EventHandler(this.MovieUpdateBtn_Click);
            // 
            // MovieDeleteBtn
            // 
            this.MovieDeleteBtn.Location = new System.Drawing.Point(4, 387);
            this.MovieDeleteBtn.Name = "MovieDeleteBtn";
            this.MovieDeleteBtn.Size = new System.Drawing.Size(81, 62);
            this.MovieDeleteBtn.TabIndex = 32;
            this.MovieDeleteBtn.Text = "Delete Movie";
            this.MovieDeleteBtn.UseVisualStyleBackColor = true;
            this.MovieDeleteBtn.Click += new System.EventHandler(this.MovieDeleteBtn_Click);
            // 
            // MovieAddBtn
            // 
            this.MovieAddBtn.Location = new System.Drawing.Point(4, 330);
            this.MovieAddBtn.Name = "MovieAddBtn";
            this.MovieAddBtn.Size = new System.Drawing.Size(80, 51);
            this.MovieAddBtn.TabIndex = 31;
            this.MovieAddBtn.Text = "Add Movie";
            this.MovieAddBtn.UseVisualStyleBackColor = true;
            this.MovieAddBtn.Click += new System.EventHandler(this.MovieAddBtn_Click);
            // 
            // MovieIssueBtn
            // 
            this.MovieIssueBtn.ForeColor = System.Drawing.Color.Green;
            this.MovieIssueBtn.Location = new System.Drawing.Point(694, 257);
            this.MovieIssueBtn.Name = "MovieIssueBtn";
            this.MovieIssueBtn.Size = new System.Drawing.Size(64, 94);
            this.MovieIssueBtn.TabIndex = 30;
            this.MovieIssueBtn.Text = "Issue Movie";
            this.MovieIssueBtn.UseVisualStyleBackColor = true;
            this.MovieIssueBtn.Click += new System.EventHandler(this.MovieIssueBtn_Click);
            // 
            // MovieReturnBtn
            // 
            this.MovieReturnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovieReturnBtn.Location = new System.Drawing.Point(618, 257);
            this.MovieReturnBtn.Name = "MovieReturnBtn";
            this.MovieReturnBtn.Size = new System.Drawing.Size(70, 94);
            this.MovieReturnBtn.TabIndex = 29;
            this.MovieReturnBtn.Text = "Return Movie";
            this.MovieReturnBtn.UseVisualStyleBackColor = true;
            this.MovieReturnBtn.Click += new System.EventHandler(this.MovieReturnBtn_Click);
            // 
            // CustomerDeleteBtn
            // 
            this.CustomerDeleteBtn.Location = new System.Drawing.Point(421, 257);
            this.CustomerDeleteBtn.Name = "CustomerDeleteBtn";
            this.CustomerDeleteBtn.Size = new System.Drawing.Size(183, 35);
            this.CustomerDeleteBtn.TabIndex = 28;
            this.CustomerDeleteBtn.Text = "Delete Customer";
            this.CustomerDeleteBtn.UseVisualStyleBackColor = true;
            this.CustomerDeleteBtn.Click += new System.EventHandler(this.CustomerDeleteBtn_Click);
            // 
            // CustomerUpdateBtn
            // 
            this.CustomerUpdateBtn.Location = new System.Drawing.Point(247, 257);
            this.CustomerUpdateBtn.Name = "CustomerUpdateBtn";
            this.CustomerUpdateBtn.Size = new System.Drawing.Size(168, 35);
            this.CustomerUpdateBtn.TabIndex = 27;
            this.CustomerUpdateBtn.Text = "Update Customer";
            this.CustomerUpdateBtn.UseVisualStyleBackColor = true;
            this.CustomerUpdateBtn.Click += new System.EventHandler(this.CustomerUpdateBtn_Click);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(454, 298);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(115, 20);
            this.phoneTxt.TabIndex = 26;
            // 
            // custIDTxt
            // 
            this.custIDTxt.Location = new System.Drawing.Point(91, 257);
            this.custIDTxt.Name = "custIDTxt";
            this.custIDTxt.Size = new System.Drawing.Size(57, 20);
            this.custIDTxt.TabIndex = 25;
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(4, 256);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(80, 68);
            this.AddCustomerBtn.TabIndex = 24;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // VideoShopYadwinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 492);
            this.Controls.Add(this.plotTxt);
            this.Controls.Add(this.custFirstNameTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.custLastNameTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rentalIDTxt);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.rentalCostTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.movieIDTxt);
            this.Controls.Add(this.MovieUpdateBtn);
            this.Controls.Add(this.MovieDeleteBtn);
            this.Controls.Add(this.MovieAddBtn);
            this.Controls.Add(this.MovieIssueBtn);
            this.Controls.Add(this.MovieReturnBtn);
            this.Controls.Add(this.CustomerDeleteBtn);
            this.Controls.Add(this.CustomerUpdateBtn);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.custIDTxt);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "VideoShopYadwinder";
            this.Text = "VideoShopYadwinder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.RadioButton allRentedRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plotTxt;
        private System.Windows.Forms.RadioButton outRentedRadioBtn;
        private System.Windows.Forms.TextBox custFirstNameTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox custLastNameTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rentalIDTxt;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox rentalCostTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox movieIDTxt;
        private System.Windows.Forms.Button MovieUpdateBtn;
        private System.Windows.Forms.Button MovieDeleteBtn;
        private System.Windows.Forms.Button MovieAddBtn;
        private System.Windows.Forms.Button MovieIssueBtn;
        private System.Windows.Forms.Button MovieReturnBtn;
        private System.Windows.Forms.Button CustomerDeleteBtn;
        private System.Windows.Forms.Button CustomerUpdateBtn;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox custIDTxt;
        private System.Windows.Forms.Button AddCustomerBtn;
    }
}