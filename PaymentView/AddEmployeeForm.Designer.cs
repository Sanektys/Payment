namespace PaymentView
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.radioSalary = new System.Windows.Forms.RadioButton();
            this.radioRate = new System.Windows.Forms.RadioButton();
            this.radioHourlyPay = new System.Windows.Forms.RadioButton();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.groupBoxChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioSalary
            // 
            this.radioSalary.Location = new System.Drawing.Point(8, 59);
            this.radioSalary.Name = "radioSalary";
            this.radioSalary.Size = new System.Drawing.Size(120, 24);
            this.radioSalary.TabIndex = 2;
            this.radioSalary.Text = "Оплата по окладу";
            this.radioSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioSalary.UseVisualStyleBackColor = true;
            this.radioSalary.Click += new System.EventHandler(this.radioSalary_Click);
            // 
            // radioRate
            // 
            this.radioRate.Location = new System.Drawing.Point(8, 37);
            this.radioRate.Name = "radioRate";
            this.radioRate.Size = new System.Drawing.Size(120, 24);
            this.radioRate.TabIndex = 1;
            this.radioRate.Text = "Оплата по ставке";
            this.radioRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioRate.UseVisualStyleBackColor = true;
            this.radioRate.Click += new System.EventHandler(this.radioRate_Click);
            // 
            // radioHourlyPay
            // 
            this.radioHourlyPay.Checked = true;
            this.radioHourlyPay.Location = new System.Drawing.Point(8, 15);
            this.radioHourlyPay.Name = "radioHourlyPay";
            this.radioHourlyPay.Size = new System.Drawing.Size(120, 24);
            this.radioHourlyPay.TabIndex = 0;
            this.radioHourlyPay.TabStop = true;
            this.radioHourlyPay.Text = "Почасовая оплата";
            this.radioHourlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioHourlyPay.UseVisualStyleBackColor = true;
            this.radioHourlyPay.Click += new System.EventHandler(this.radioHourlyPay_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRandom.Location = new System.Drawing.Point(186, 97);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(131, 23);
            this.buttonRandom.TabIndex = 14;
            this.buttonRandom.Text = "Случайные данные";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Visible = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOk.Location = new System.Drawing.Point(186, 167);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(65, 23);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "Принять";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(252, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxChoice.Controls.Add(this.radioSalary);
            this.groupBoxChoice.Controls.Add(this.radioHourlyPay);
            this.groupBoxChoice.Controls.Add(this.radioRate);
            this.groupBoxChoice.Location = new System.Drawing.Point(186, 6);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(131, 85);
            this.groupBoxChoice.TabIndex = 17;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Метод оплаты";
            // 
            // AddEmployeeForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(324, 197);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEmployeeForm";
            this.Opacity = 0.99D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить\\редактировать";
            this.groupBoxChoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioSalary;
        private System.Windows.Forms.RadioButton radioRate;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.RadioButton radioHourlyPay;
    }
}