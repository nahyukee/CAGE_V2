
namespace WorkoutApp
{
    partial class FormWorkouts
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
            this.panelWorkouts = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDesignWorkout = new WorkoutApp.Round_Button.RoundButton();
            this.txtFri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThurs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTues = new System.Windows.Forms.TextBox();
            this.lblTues = new System.Windows.Forms.Label();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.lblMon = new System.Windows.Forms.Label();
            this.boxWorkout = new System.Windows.Forms.ComboBox();
            this.panelWorkouts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkouts
            // 
            this.panelWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panelWorkouts.Controls.Add(this.label1);
            this.panelWorkouts.Controls.Add(this.BtnDesignWorkout);
            this.panelWorkouts.Controls.Add(this.txtFri);
            this.panelWorkouts.Controls.Add(this.label4);
            this.panelWorkouts.Controls.Add(this.txtThurs);
            this.panelWorkouts.Controls.Add(this.label3);
            this.panelWorkouts.Controls.Add(this.txtWed);
            this.panelWorkouts.Controls.Add(this.label2);
            this.panelWorkouts.Controls.Add(this.txtTues);
            this.panelWorkouts.Controls.Add(this.lblTues);
            this.panelWorkouts.Controls.Add(this.txtMon);
            this.panelWorkouts.Controls.Add(this.lblMon);
            this.panelWorkouts.Controls.Add(this.boxWorkout);
            this.panelWorkouts.ForeColor = System.Drawing.Color.White;
            this.panelWorkouts.Location = new System.Drawing.Point(-6, 0);
            this.panelWorkouts.Margin = new System.Windows.Forms.Padding(0);
            this.panelWorkouts.Name = "panelWorkouts";
            this.panelWorkouts.Size = new System.Drawing.Size(753, 356);
            this.panelWorkouts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(312, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Workouts";
            // 
            // BtnDesignWorkout
            // 
            this.BtnDesignWorkout.BackColor = System.Drawing.Color.White;
            this.BtnDesignWorkout.BackGroundColor = System.Drawing.Color.White;
            this.BtnDesignWorkout.BorderColor = System.Drawing.Color.White;
            this.BtnDesignWorkout.BorderRadius = 25;
            this.BtnDesignWorkout.BorderSize = 0;
            this.BtnDesignWorkout.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnDesignWorkout.FlatAppearance.BorderSize = 0;
            this.BtnDesignWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesignWorkout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesignWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.BtnDesignWorkout.Location = new System.Drawing.Point(309, 78);
            this.BtnDesignWorkout.Name = "BtnDesignWorkout";
            this.BtnDesignWorkout.Size = new System.Drawing.Size(137, 25);
            this.BtnDesignWorkout.TabIndex = 3;
            this.BtnDesignWorkout.Text = "Your Workout";
            this.BtnDesignWorkout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.BtnDesignWorkout.UseVisualStyleBackColor = false;
            this.BtnDesignWorkout.UseWaitCursor = true;
            this.BtnDesignWorkout.Click += new System.EventHandler(this.BtnDesignWorkout_Click);
            // 
            // txtFri
            // 
            this.txtFri.AcceptsReturn = true;
            this.txtFri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtFri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFri.ForeColor = System.Drawing.Color.White;
            this.txtFri.Location = new System.Drawing.Point(598, 156);
            this.txtFri.Multiline = true;
            this.txtFri.Name = "txtFri";
            this.txtFri.ReadOnly = true;
            this.txtFri.Size = new System.Drawing.Size(138, 188);
            this.txtFri.TabIndex = 0;
            this.txtFri.TabStop = false;
            this.txtFri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(625, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "|FRIDAY|";
            // 
            // txtThurs
            // 
            this.txtThurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtThurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThurs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThurs.ForeColor = System.Drawing.Color.White;
            this.txtThurs.Location = new System.Drawing.Point(453, 156);
            this.txtThurs.Multiline = true;
            this.txtThurs.Name = "txtThurs";
            this.txtThurs.ReadOnly = true;
            this.txtThurs.Size = new System.Drawing.Size(138, 188);
            this.txtThurs.TabIndex = 0;
            this.txtThurs.TabStop = false;
            this.txtThurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "|THURSDAY|";
            // 
            // txtWed
            // 
            this.txtWed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtWed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWed.ForeColor = System.Drawing.Color.White;
            this.txtWed.Location = new System.Drawing.Point(308, 156);
            this.txtWed.Multiline = true;
            this.txtWed.Name = "txtWed";
            this.txtWed.ReadOnly = true;
            this.txtWed.Size = new System.Drawing.Size(138, 188);
            this.txtWed.TabIndex = 0;
            this.txtWed.TabStop = false;
            this.txtWed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "|WEDNESDAY|";
            // 
            // txtTues
            // 
            this.txtTues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtTues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTues.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTues.ForeColor = System.Drawing.Color.White;
            this.txtTues.Location = new System.Drawing.Point(163, 156);
            this.txtTues.Multiline = true;
            this.txtTues.Name = "txtTues";
            this.txtTues.ReadOnly = true;
            this.txtTues.Size = new System.Drawing.Size(138, 188);
            this.txtTues.TabIndex = 0;
            this.txtTues.TabStop = false;
            this.txtTues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTues
            // 
            this.lblTues.AutoSize = true;
            this.lblTues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTues.ForeColor = System.Drawing.Color.White;
            this.lblTues.Location = new System.Drawing.Point(174, 132);
            this.lblTues.Name = "lblTues";
            this.lblTues.Size = new System.Drawing.Size(95, 19);
            this.lblTues.TabIndex = 0;
            this.lblTues.Text = "|TUESDAY|";
            // 
            // txtMon
            // 
            this.txtMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.txtMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMon.ForeColor = System.Drawing.Color.White;
            this.txtMon.Location = new System.Drawing.Point(18, 156);
            this.txtMon.Multiline = true;
            this.txtMon.Name = "txtMon";
            this.txtMon.ReadOnly = true;
            this.txtMon.Size = new System.Drawing.Size(138, 188);
            this.txtMon.TabIndex = 0;
            this.txtMon.TabStop = false;
            this.txtMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.Color.White;
            this.lblMon.Location = new System.Drawing.Point(38, 132);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(101, 19);
            this.lblMon.TabIndex = 0;
            this.lblMon.Text = "|MONDAY|";
            // 
            // boxWorkout
            // 
            this.boxWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxWorkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxWorkout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWorkout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxWorkout.FormattingEnabled = true;
            this.boxWorkout.Items.AddRange(new object[] {
            "2",
            "4",
            "5"});
            this.boxWorkout.Location = new System.Drawing.Point(214, 47);
            this.boxWorkout.Name = "boxWorkout";
            this.boxWorkout.Size = new System.Drawing.Size(337, 25);
            this.boxWorkout.TabIndex = 1;
            this.boxWorkout.Text = "How many days would you like to workout? ";
            this.boxWorkout.SelectedIndexChanged += new System.EventHandler(this.boxWorkout_SelectedIndexChanged);
            // 
            // FormWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(756, 365);
            this.Controls.Add(this.panelWorkouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWorkouts";
            this.Text = "Workouts";
            this.panelWorkouts.ResumeLayout(false);
            this.panelWorkouts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWorkouts;
        private System.Windows.Forms.ComboBox boxWorkout;
        private System.Windows.Forms.TextBox txtFri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTues;
        private System.Windows.Forms.Label lblTues;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.Label lblMon;
        private Round_Button.RoundButton BtnDesignWorkout;
        private System.Windows.Forms.Label label1;
    }
}