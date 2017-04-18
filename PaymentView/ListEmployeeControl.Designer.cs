namespace PaymentView
{
    partial class ListEmployeeControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.labelExperience2 = new System.Windows.Forms.Label();
            this.maskedWaste = new System.Windows.Forms.MaskedTextBox();
            this.labelWaste = new System.Windows.Forms.Label();
            this.maskedName = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxEducation = new System.Windows.Forms.GroupBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.maskedExperience = new System.Windows.Forms.MaskedTextBox();
            this.labelExperience1 = new System.Windows.Forms.Label();
            this.maskedSurname = new System.Windows.Forms.MaskedTextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderExperience = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEducation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWaste = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipWarning = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxEducation.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWaste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxPayment);
            this.panel1.Controls.Add(this.labelExperience2);
            this.panel1.Controls.Add(this.maskedWaste);
            this.panel1.Controls.Add(this.labelWaste);
            this.panel1.Controls.Add(this.maskedName);
            this.panel1.Controls.Add(this.groupBoxEducation);
            this.panel1.Controls.Add(this.groupBoxPosition);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.maskedExperience);
            this.panel1.Controls.Add(this.labelExperience1);
            this.panel1.Controls.Add(this.maskedSurname);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 223);
            this.panel1.TabIndex = 12;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBoxPayment);
            this.groupBoxPayment.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxPayment.Location = new System.Drawing.Point(-3, 179);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(156, 41);
            this.groupBoxPayment.TabIndex = 25;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Зарплата за месяц:";
            this.groupBoxPayment.Visible = false;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPayment.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPayment.Location = new System.Drawing.Point(41, 18);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.ReadOnly = true;
            this.textBoxPayment.ShortcutsEnabled = false;
            this.textBoxPayment.Size = new System.Drawing.Size(74, 13);
            this.textBoxPayment.TabIndex = 24;
            this.textBoxPayment.TabStop = false;
            this.textBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelExperience2
            // 
            this.labelExperience2.AutoSize = true;
            this.labelExperience2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelExperience2.Location = new System.Drawing.Point(99, 45);
            this.labelExperience2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelExperience2.Name = "labelExperience2";
            this.labelExperience2.Size = new System.Drawing.Size(56, 13);
            this.labelExperience2.TabIndex = 22;
            this.labelExperience2.Text = "лет (года)";
            // 
            // maskedWaste
            // 
            this.maskedWaste.BackColor = System.Drawing.SystemColors.Control;
            this.maskedWaste.BeepOnError = true;
            this.maskedWaste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedWaste.Location = new System.Drawing.Point(92, 159);
            this.maskedWaste.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maskedWaste.Mask = "000";
            this.maskedWaste.Name = "maskedWaste";
            this.maskedWaste.Size = new System.Drawing.Size(18, 13);
            this.maskedWaste.TabIndex = 21;
            // 
            // labelWaste
            // 
            this.labelWaste.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelWaste.Location = new System.Drawing.Point(3, 159);
            this.labelWaste.Name = "labelWaste";
            this.labelWaste.Size = new System.Drawing.Size(89, 13);
            this.labelWaste.TabIndex = 0;
            this.labelWaste.Text = "Отработанных...";
            // 
            // maskedName
            // 
            this.maskedName.BackColor = System.Drawing.SystemColors.Control;
            this.maskedName.BeepOnError = true;
            this.maskedName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedName.Location = new System.Drawing.Point(35, 5);
            this.maskedName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.maskedName.Mask = ">L<LL????????";
            this.maskedName.Name = "maskedName";
            this.maskedName.Size = new System.Drawing.Size(66, 13);
            this.maskedName.TabIndex = 0;
            // 
            // groupBoxEducation
            // 
            this.groupBoxEducation.Controls.Add(this.comboBoxEducation);
            this.groupBoxEducation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxEducation.Location = new System.Drawing.Point(-3, 112);
            this.groupBoxEducation.Name = "groupBoxEducation";
            this.groupBoxEducation.Size = new System.Drawing.Size(156, 45);
            this.groupBoxEducation.TabIndex = 20;
            this.groupBoxEducation.TabStop = false;
            this.groupBoxEducation.Text = "Имеющееся образование:";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Items.AddRange(new object[] {
            "Высшее",
            "Отсутствует",
            "Среднее"});
            this.comboBoxEducation.Location = new System.Drawing.Point(9, 16);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(140, 21);
            this.comboBoxEducation.Sorted = true;
            this.comboBoxEducation.TabIndex = 1;
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.comboBoxPosition);
            this.groupBoxPosition.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxPosition.Location = new System.Drawing.Point(-3, 65);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(156, 45);
            this.groupBoxPosition.TabIndex = 19;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Занимаемая должность:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Инженер",
            "Младший сотрудник",
            "Офисный сотрудник",
            "Рабочий"});
            this.comboBoxPosition.Location = new System.Drawing.Point(9, 16);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPosition.Sorted = true;
            this.comboBoxPosition.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя:";
            // 
            // maskedExperience
            // 
            this.maskedExperience.BackColor = System.Drawing.SystemColors.Control;
            this.maskedExperience.BeepOnError = true;
            this.maskedExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedExperience.Location = new System.Drawing.Point(88, 45);
            this.maskedExperience.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maskedExperience.Mask = "00";
            this.maskedExperience.Name = "maskedExperience";
            this.maskedExperience.Size = new System.Drawing.Size(12, 13);
            this.maskedExperience.TabIndex = 2;
            this.toolTipWarning.SetToolTip(this.maskedExperience, "Не больше 80-ти лет");
            // 
            // labelExperience1
            // 
            this.labelExperience1.AutoSize = true;
            this.labelExperience1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelExperience1.Location = new System.Drawing.Point(3, 45);
            this.labelExperience1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelExperience1.Name = "labelExperience1";
            this.labelExperience1.Size = new System.Drawing.Size(86, 13);
            this.labelExperience1.TabIndex = 1;
            this.labelExperience1.Text = "Трудовой стаж:";
            // 
            // maskedSurname
            // 
            this.maskedSurname.BackColor = System.Drawing.SystemColors.Control;
            this.maskedSurname.BeepOnError = true;
            this.maskedSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedSurname.Location = new System.Drawing.Point(62, 25);
            this.maskedSurname.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.maskedSurname.Mask = ">L<LL????????????";
            this.maskedSurname.Name = "maskedSurname";
            this.maskedSurname.Size = new System.Drawing.Size(93, 13);
            this.maskedSurname.TabIndex = 1;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelSurname.Location = new System.Drawing.Point(3, 25);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Фамилия:";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderSurname
            // 
            this.errorProviderSurname.ContainerControl = this;
            // 
            // errorProviderExperience
            // 
            this.errorProviderExperience.ContainerControl = this;
            // 
            // errorProviderEducation
            // 
            this.errorProviderEducation.ContainerControl = this;
            // 
            // errorProviderWaste
            // 
            this.errorProviderWaste.ContainerControl = this;
            // 
            // toolTipWarning
            // 
            this.toolTipWarning.AutomaticDelay = 100;
            this.toolTipWarning.AutoPopDelay = 10000;
            this.toolTipWarning.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolTipWarning.ForeColor = System.Drawing.Color.Coral;
            this.toolTipWarning.InitialDelay = 100;
            this.toolTipWarning.IsBalloon = true;
            this.toolTipWarning.ReshowDelay = 20;
            this.toolTipWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // ListEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListEmployeeControl";
            this.Size = new System.Drawing.Size(177, 228);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxEducation.ResumeLayout(false);
            this.groupBoxPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWaste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedName;
        private System.Windows.Forms.GroupBox groupBoxEducation;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MaskedTextBox maskedExperience;
        private System.Windows.Forms.Label labelExperience1;
        private System.Windows.Forms.MaskedTextBox maskedSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.MaskedTextBox maskedWaste;
        private System.Windows.Forms.Label labelWaste;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label labelExperience2;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderSurname;
        private System.Windows.Forms.ErrorProvider errorProviderExperience;
        private System.Windows.Forms.ErrorProvider errorProviderEducation;
        private System.Windows.Forms.ErrorProvider errorProviderWaste;
        private System.Windows.Forms.ToolTip toolTipWarning;

    }
}
