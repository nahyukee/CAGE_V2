
namespace WorkoutApp
{
    partial class FormUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInfo));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMacros = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.boxGender = new System.Windows.Forms.ComboBox();
            this.boxActivity = new System.Windows.Forms.ComboBox();
            this.boxGoals = new System.Windows.Forms.ComboBox();
            this.lblMacros = new System.Windows.Forms.Label();
            this.lblCaloriesPerDay = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalCalories = new System.Windows.Forms.TextBox();
            this.roundButton4 = new WorkoutApp.Round_Button.RoundButton();
            this.panelUserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.AcceptsTab = true;
            this.txtName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(12, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            this.txtName.UseWaitCursor = true;
            this.txtName.WordWrap = false;
            this.txtName.ModifiedChanged += new System.EventHandler(this.txtName_ModifiedChanged);
            // 
            // txtMacros
            // 
            this.txtMacros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtMacros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMacros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacros.ForeColor = System.Drawing.Color.White;
            this.txtMacros.Location = new System.Drawing.Point(554, 74);
            this.txtMacros.MaxLength = 20;
            this.txtMacros.Multiline = true;
            this.txtMacros.Name = "txtMacros";
            this.txtMacros.ReadOnly = true;
            this.txtMacros.Size = new System.Drawing.Size(166, 158);
            this.txtMacros.TabIndex = 0;
            this.txtMacros.TabStop = false;
            this.txtMacros.WordWrap = false;
            // 
            // txtWeight
            // 
            this.txtWeight.AcceptsReturn = true;
            this.txtWeight.AcceptsTab = true;
            this.txtWeight.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtWeight.Location = new System.Drawing.Point(12, 73);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(155, 23);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.Text = "Weight (Ibs)";
            this.txtWeight.UseWaitCursor = true;
            this.txtWeight.WordWrap = false;
            this.txtWeight.ModifiedChanged += new System.EventHandler(this.txtWeight_ModifiedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.AcceptsReturn = true;
            this.txtHeight.AcceptsTab = true;
            this.txtHeight.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtHeight.Location = new System.Drawing.Point(12, 39);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(155, 23);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.Text = "Height (Inches)";
            this.txtHeight.UseWaitCursor = true;
            this.txtHeight.WordWrap = false;
            this.txtHeight.ModifiedChanged += new System.EventHandler(this.txtHeight_ModifiedChanged);
            // 
            // txtAge
            // 
            this.txtAge.AcceptsReturn = true;
            this.txtAge.AcceptsTab = true;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAge.Location = new System.Drawing.Point(12, 107);
            this.txtAge.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(155, 23);
            this.txtAge.TabIndex = 4;
            this.txtAge.Text = "Age";
            this.txtAge.UseWaitCursor = true;
            this.txtAge.WordWrap = false;
            this.txtAge.ModifiedChanged += new System.EventHandler(this.txtAge_ModifiedChanged);
            // 
            // boxGender
            // 
            this.boxGender.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxGender.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxGender.FormattingEnabled = true;
            this.boxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.boxGender.Location = new System.Drawing.Point(12, 141);
            this.boxGender.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.boxGender.Name = "boxGender";
            this.boxGender.Size = new System.Drawing.Size(155, 25);
            this.boxGender.TabIndex = 5;
            this.boxGender.Text = "Gender";
            this.boxGender.UseWaitCursor = true;
            this.boxGender.SelectedValueChanged += new System.EventHandler(this.boxGoals_SelectedValueChanged);
            // 
            // boxActivity
            // 
            this.boxActivity.CausesValidation = false;
            this.boxActivity.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxActivity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxActivity.FormattingEnabled = true;
            this.boxActivity.Items.AddRange(new object[] {
            "Little",
            "Light",
            "Moderate",
            "Vigorous",
            "Extreme"});
            this.boxActivity.Location = new System.Drawing.Point(12, 176);
            this.boxActivity.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.boxActivity.Name = "boxActivity";
            this.boxActivity.Size = new System.Drawing.Size(155, 25);
            this.boxActivity.TabIndex = 6;
            this.boxActivity.Text = "Activity Level";
            this.boxActivity.UseWaitCursor = true;
            // 
            // boxGoals
            // 
            this.boxGoals.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boxGoals.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxGoals.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxGoals.FormattingEnabled = true;
            this.boxGoals.Items.AddRange(new object[] {
            "Lose",
            "Maintain",
            "Gain"});
            this.boxGoals.Location = new System.Drawing.Point(12, 211);
            this.boxGoals.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.boxGoals.Name = "boxGoals";
            this.boxGoals.Size = new System.Drawing.Size(155, 25);
            this.boxGoals.TabIndex = 7;
            this.boxGoals.Text = "Goal ";
            this.boxGoals.UseWaitCursor = true;
            // 
            // lblMacros
            // 
            this.lblMacros.AutoSize = true;
            this.lblMacros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacros.ForeColor = System.Drawing.Color.White;
            this.lblMacros.Location = new System.Drawing.Point(479, 74);
            this.lblMacros.Name = "lblMacros";
            this.lblMacros.Size = new System.Drawing.Size(69, 19);
            this.lblMacros.TabIndex = 0;
            this.lblMacros.Text = "Macros:";
            // 
            // lblCaloriesPerDay
            // 
            this.lblCaloriesPerDay.AutoSize = true;
            this.lblCaloriesPerDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesPerDay.ForeColor = System.Drawing.Color.White;
            this.lblCaloriesPerDay.Location = new System.Drawing.Point(479, 42);
            this.lblCaloriesPerDay.Name = "lblCaloriesPerDay";
            this.lblCaloriesPerDay.Size = new System.Drawing.Size(122, 19);
            this.lblCaloriesPerDay.TabIndex = 0;
            this.lblCaloriesPerDay.Text = "Daily Calories: ";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panelUserInfo.Controls.Add(this.panel1);
            this.panelUserInfo.Controls.Add(this.label3);
            this.panelUserInfo.Controls.Add(this.label2);
            this.panelUserInfo.Controls.Add(this.label1);
            this.panelUserInfo.Controls.Add(this.txtTotalCalories);
            this.panelUserInfo.Controls.Add(this.txtMacros);
            this.panelUserInfo.Controls.Add(this.lblCaloriesPerDay);
            this.panelUserInfo.Controls.Add(this.lblMacros);
            this.panelUserInfo.Location = new System.Drawing.Point(12, 2);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(732, 361);
            this.panelUserInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundButton4);
            this.panel1.Controls.Add(this.boxGoals);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.boxGender);
            this.panel1.Controls.Add(this.boxActivity);
            this.panel1.Location = new System.Drawing.Point(303, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 314);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "To START, press \'TAB\' and enter your information for each line.  Click \'CALCULATE" +
    "\' to see your daily calories and macros!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 251);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(232, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Macros and Calories";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCalories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCalories.ForeColor = System.Drawing.Color.White;
            this.txtTotalCalories.Location = new System.Drawing.Point(607, 45);
            this.txtTotalCalories.Multiline = true;
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.ReadOnly = true;
            this.txtTotalCalories.Size = new System.Drawing.Size(94, 23);
            this.txtTotalCalories.TabIndex = 0;
            this.txtTotalCalories.TabStop = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.White;
            this.roundButton4.BackGroundColor = System.Drawing.Color.White;
            this.roundButton4.BorderColor = System.Drawing.Color.White;
            this.roundButton4.BorderRadius = 25;
            this.roundButton4.BorderSize = 0;
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(230)))), ((int)(((byte)(169)))));
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(230)))), ((int)(((byte)(169)))));
            this.roundButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(230)))), ((int)(((byte)(169)))));
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.roundButton4.Location = new System.Drawing.Point(24, 244);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(128, 27);
            this.roundButton4.TabIndex = 10;
            this.roundButton4.Text = "Calculate";
            this.roundButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.BtnCalcMacros_Click);
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(756, 365);
            this.Controls.Add(this.panelUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserInfo";
            this.Text = "User Info";
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtMacros;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox boxGender;
        private System.Windows.Forms.ComboBox boxActivity;
        private System.Windows.Forms.ComboBox boxGoals;
        private System.Windows.Forms.Label lblMacros;
        private System.Windows.Forms.Label lblCaloriesPerDay;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Round_Button.RoundButton roundButton4;
    }
}