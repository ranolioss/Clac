
namespace Calcu2
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnDivid = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.butn0 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.butn9 = new System.Windows.Forms.Button();
            this.butn8 = new System.Windows.Forms.Button();
            this.butn7 = new System.Windows.Forms.Button();
            this.btnMinse = new System.Windows.Forms.Button();
            this.butn6 = new System.Windows.Forms.Button();
            this.butn5 = new System.Windows.Forms.Button();
            this.butn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.butn3 = new System.Windows.Forms.Button();
            this.butn2 = new System.Windows.Forms.Button();
            this.butn1 = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRemain = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnclear.Location = new System.Drawing.Point(216, 125);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(62, 48);
            this.btnclear.TabIndex = 37;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnDivid
            // 
            this.btnDivid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDivid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivid.Location = new System.Drawing.Point(216, 346);
            this.btnDivid.Name = "btnDivid";
            this.btnDivid.Size = new System.Drawing.Size(62, 48);
            this.btnDivid.TabIndex = 35;
            this.btnDivid.Text = "/";
            this.btnDivid.UseVisualStyleBackColor = false;
            this.btnDivid.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnDivid.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnDivid.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(148, 346);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(62, 48);
            this.btnEqual.TabIndex = 34;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnEqual.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.Location = new System.Drawing.Point(79, 346);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(63, 48);
            this.btnpoint.TabIndex = 33;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            this.btnpoint.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnpoint.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn0
            // 
            this.butn0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn0.Location = new System.Drawing.Point(13, 346);
            this.butn0.Name = "butn0";
            this.butn0.Size = new System.Drawing.Size(60, 48);
            this.butn0.TabIndex = 32;
            this.butn0.Text = "0";
            this.butn0.UseVisualStyleBackColor = false;
            this.butn0.Click += new System.EventHandler(this.butn0_Click);
            this.butn0.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn0.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(216, 292);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(62, 48);
            this.btnMulti.TabIndex = 31;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnMulti.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnMulti.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn9
            // 
            this.butn9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn9.Location = new System.Drawing.Point(148, 292);
            this.butn9.Name = "butn9";
            this.butn9.Size = new System.Drawing.Size(62, 48);
            this.butn9.TabIndex = 30;
            this.butn9.Text = "9";
            this.butn9.UseVisualStyleBackColor = false;
            this.butn9.Click += new System.EventHandler(this.butn1_Click);
            this.butn9.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn9.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn8
            // 
            this.butn8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn8.Location = new System.Drawing.Point(79, 292);
            this.butn8.Name = "butn8";
            this.butn8.Size = new System.Drawing.Size(63, 48);
            this.butn8.TabIndex = 29;
            this.butn8.Text = "8";
            this.butn8.UseVisualStyleBackColor = false;
            this.butn8.Click += new System.EventHandler(this.butn1_Click);
            this.butn8.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn8.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn7
            // 
            this.butn7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn7.Location = new System.Drawing.Point(13, 292);
            this.butn7.Name = "butn7";
            this.butn7.Size = new System.Drawing.Size(60, 48);
            this.butn7.TabIndex = 28;
            this.butn7.Text = "7";
            this.butn7.UseVisualStyleBackColor = false;
            this.butn7.Click += new System.EventHandler(this.butn1_Click);
            this.butn7.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn7.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnMinse
            // 
            this.btnMinse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMinse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinse.Location = new System.Drawing.Point(216, 238);
            this.btnMinse.Name = "btnMinse";
            this.btnMinse.Size = new System.Drawing.Size(62, 48);
            this.btnMinse.TabIndex = 27;
            this.btnMinse.Text = "-";
            this.btnMinse.UseVisualStyleBackColor = false;
            this.btnMinse.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnMinse.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnMinse.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn6
            // 
            this.butn6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn6.Location = new System.Drawing.Point(148, 238);
            this.butn6.Name = "butn6";
            this.butn6.Size = new System.Drawing.Size(62, 48);
            this.butn6.TabIndex = 26;
            this.butn6.Text = "6";
            this.butn6.UseVisualStyleBackColor = false;
            this.butn6.Click += new System.EventHandler(this.butn1_Click);
            this.butn6.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn6.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn5
            // 
            this.butn5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn5.Location = new System.Drawing.Point(79, 238);
            this.butn5.Name = "butn5";
            this.butn5.Size = new System.Drawing.Size(63, 48);
            this.butn5.TabIndex = 25;
            this.butn5.Text = "5";
            this.butn5.UseVisualStyleBackColor = false;
            this.butn5.Click += new System.EventHandler(this.butn1_Click);
            this.butn5.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn5.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn4
            // 
            this.butn4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn4.Location = new System.Drawing.Point(13, 238);
            this.butn4.Name = "butn4";
            this.butn4.Size = new System.Drawing.Size(60, 48);
            this.butn4.TabIndex = 24;
            this.butn4.Text = "4";
            this.butn4.UseVisualStyleBackColor = false;
            this.butn4.Click += new System.EventHandler(this.butn1_Click);
            this.butn4.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn4.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(216, 179);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 48);
            this.btnPlus.TabIndex = 23;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnPlus.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnPlus.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn3
            // 
            this.butn3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn3.Location = new System.Drawing.Point(148, 179);
            this.butn3.Name = "butn3";
            this.butn3.Size = new System.Drawing.Size(62, 48);
            this.butn3.TabIndex = 22;
            this.butn3.Text = "3";
            this.butn3.UseVisualStyleBackColor = false;
            this.butn3.Click += new System.EventHandler(this.butn1_Click);
            this.butn3.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn3.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn2
            // 
            this.butn2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn2.Location = new System.Drawing.Point(79, 179);
            this.butn2.Name = "butn2";
            this.butn2.Size = new System.Drawing.Size(63, 48);
            this.butn2.TabIndex = 21;
            this.butn2.Text = "2";
            this.butn2.UseVisualStyleBackColor = false;
            this.butn2.Click += new System.EventHandler(this.butn1_Click);
            this.butn2.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn2.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // butn1
            // 
            this.butn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn1.Location = new System.Drawing.Point(13, 179);
            this.butn1.Name = "butn1";
            this.butn1.Size = new System.Drawing.Size(60, 48);
            this.butn1.TabIndex = 20;
            this.butn1.Text = "1";
            this.butn1.UseVisualStyleBackColor = false;
            this.butn1.Click += new System.EventHandler(this.butn1_Click);
            this.butn1.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.butn1.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(0, 1);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(300, 35);
            this.txtNumber.TabIndex = 19;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 42);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(300, 38);
            this.txtResult.TabIndex = 38;
            // 
            // btnRemain
            // 
            this.btnRemain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemain.Location = new System.Drawing.Point(12, 125);
            this.btnRemain.Name = "btnRemain";
            this.btnRemain.Size = new System.Drawing.Size(62, 48);
            this.btnRemain.TabIndex = 39;
            this.btnRemain.Text = "%";
            this.btnRemain.UseVisualStyleBackColor = false;
            this.btnRemain.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnRemain.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnRemain.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.Location = new System.Drawing.Point(80, 125);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(62, 48);
            this.btnPower.TabIndex = 41;
            this.btnPower.Text = "^";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnPower.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnPower.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(148, 125);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(62, 48);
            this.btnRoot.TabIndex = 42;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnRoot.MouseEnter += new System.EventHandler(this.butn1_MouseEnter);
            this.btnRoot.MouseLeave += new System.EventHandler(this.butn1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnRemain);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDivid);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.butn0);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.butn9);
            this.Controls.Add(this.butn8);
            this.Controls.Add(this.butn7);
            this.Controls.Add(this.btnMinse);
            this.Controls.Add(this.butn6);
            this.Controls.Add(this.butn5);
            this.Controls.Add(this.butn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.butn3);
            this.Controls.Add(this.butn2);
            this.Controls.Add(this.butn1);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnDivid;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button butn0;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button butn9;
        private System.Windows.Forms.Button butn8;
        private System.Windows.Forms.Button butn7;
        private System.Windows.Forms.Button btnMinse;
        private System.Windows.Forms.Button butn6;
        private System.Windows.Forms.Button butn5;
        private System.Windows.Forms.Button butn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button butn3;
        private System.Windows.Forms.Button butn2;
        private System.Windows.Forms.Button butn1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnRemain;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnRoot;
    }
}

