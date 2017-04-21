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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEmployeeControl));
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelExperience2 = new System.Windows.Forms.Label();
            this.maskedWaste = new System.Windows.Forms.MaskedTextBox();
            this.labelWaste = new System.Windows.Forms.Label();
            this.maskedName = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxEducation = new System.Windows.Forms.GroupBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.labelPosition = new System.Windows.Forms.Label();
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
            this.errorProviderPosition = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxEducation.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.groupBoxPayment);
            this.panelMain.Controls.Add(this.labelExperience2);
            this.panelMain.Controls.Add(this.maskedWaste);
            this.panelMain.Controls.Add(this.labelWaste);
            this.panelMain.Controls.Add(this.maskedName);
            this.panelMain.Controls.Add(this.groupBoxEducation);
            this.panelMain.Controls.Add(this.groupBoxPosition);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.maskedExperience);
            this.panelMain.Controls.Add(this.labelExperience1);
            this.panelMain.Controls.Add(this.maskedSurname);
            this.panelMain.Controls.Add(this.labelSurname);
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(171, 223);
            this.panelMain.TabIndex = 12;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.labelPayment);
            this.groupBoxPayment.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxPayment.Location = new System.Drawing.Point(-3, 179);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(156, 41);
            this.groupBoxPayment.TabIndex = 25;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Зарплата за месяц:";
            this.groupBoxPayment.Visible = false;
            // 
            // labelPayment
            // 
            this.labelPayment.ForeColor = System.Drawing.Color.Black;
            this.labelPayment.Location = new System.Drawing.Point(25, 20);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(110, 13);
            this.labelPayment.TabIndex = 28;
            this.labelPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExperience2
            // 
            this.labelExperience2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelExperience2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelExperience2.Location = new System.Drawing.Point(103, 45);
            this.labelExperience2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelExperience2.Name = "labelExperience2";
            this.labelExperience2.Size = new System.Drawing.Size(49, 13);
            this.labelExperience2.TabIndex = 22;
            this.labelExperience2.Text = "лет (года)";
            this.labelExperience2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedWaste
            // 
            this.maskedWaste.BackColor = System.Drawing.SystemColors.Control;
            this.maskedWaste.BeepOnError = true;
            this.maskedWaste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedWaste.Location = new System.Drawing.Point(118, 159);
            this.maskedWaste.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maskedWaste.Mask = "000";
            this.maskedWaste.Name = "maskedWaste";
            this.maskedWaste.Size = new System.Drawing.Size(18, 13);
            this.maskedWaste.TabIndex = 21;
            this.maskedWaste.Click += new System.EventHandler(this.DefaultStartPosition);
            this.maskedWaste.Enter += new System.EventHandler(this.RemovalCarriage);
            this.maskedWaste.Leave += new System.EventHandler(this.maskedWaste_Leave);
            this.maskedWaste.MouseEnter += new System.EventHandler(this.maskedWaste_MouseEnter);
            // 
            // labelWaste
            // 
            this.labelWaste.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelWaste.Location = new System.Drawing.Point(3, 159);
            this.labelWaste.Name = "labelWaste";
            this.labelWaste.Size = new System.Drawing.Size(115, 13);
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
            this.maskedName.Click += new System.EventHandler(this.DefaultStartPosition);
            this.maskedName.Enter += new System.EventHandler(this.RemovalCarriage);
            this.maskedName.Leave += new System.EventHandler(this.maskedName_Leave);
            // 
            // groupBoxEducation
            // 
            this.groupBoxEducation.Controls.Add(this.labelEducation);
            this.groupBoxEducation.Controls.Add(this.comboBoxEducation);
            this.groupBoxEducation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxEducation.Location = new System.Drawing.Point(-3, 112);
            this.groupBoxEducation.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBoxEducation.Name = "groupBoxEducation";
            this.groupBoxEducation.Size = new System.Drawing.Size(156, 45);
            this.groupBoxEducation.TabIndex = 20;
            this.groupBoxEducation.TabStop = false;
            this.groupBoxEducation.Text = "Имеющееся образование:";
            // 
            // labelEducation
            // 
            this.labelEducation.ForeColor = System.Drawing.Color.Black;
            this.labelEducation.Location = new System.Drawing.Point(25, 18);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(110, 13);
            this.labelEducation.TabIndex = 27;
            this.labelEducation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEducation.Visible = false;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducation.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Items.AddRange(new object[] {
            "Отсутствует",
            "Среднее",
            "Высшее"});
            this.comboBoxEducation.Location = new System.Drawing.Point(9, 16);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(140, 21);
            this.comboBoxEducation.TabIndex = 1;
            this.comboBoxEducation.Leave += new System.EventHandler(this.comboBoxEducation_Leave);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.labelPosition);
            this.groupBoxPosition.Controls.Add(this.comboBoxPosition);
            this.groupBoxPosition.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxPosition.Location = new System.Drawing.Point(-3, 65);
            this.groupBoxPosition.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(156, 45);
            this.groupBoxPosition.TabIndex = 19;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Занимаемая должность:";
            // 
            // labelPosition
            // 
            this.labelPosition.ForeColor = System.Drawing.Color.Black;
            this.labelPosition.Location = new System.Drawing.Point(25, 18);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(110, 13);
            this.labelPosition.TabIndex = 26;
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPosition.Visible = false;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Инженер",
            "Младший сотрудник",
            "Офисный сотрудник",
            "Рабочий"});
            this.comboBoxPosition.Location = new System.Drawing.Point(9, 16);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPosition.TabIndex = 0;
            this.comboBoxPosition.Leave += new System.EventHandler(this.comboBoxPosition_Leave);
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
            this.maskedExperience.Click += new System.EventHandler(this.DefaultStartPosition);
            this.maskedExperience.Enter += new System.EventHandler(this.RemovalCarriage);
            this.maskedExperience.Leave += new System.EventHandler(this.maskedExperience_Leave);
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
            this.maskedSurname.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maskedSurname.Mask = ">L<LL????????????";
            this.maskedSurname.Name = "maskedSurname";
            this.maskedSurname.Size = new System.Drawing.Size(90, 13);
            this.maskedSurname.TabIndex = 1;
            this.maskedSurname.Click += new System.EventHandler(this.DefaultStartPosition);
            this.maskedSurname.Enter += new System.EventHandler(this.RemovalCarriage);
            this.maskedSurname.Leave += new System.EventHandler(this.maskedSurname_Leave);
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
            this.errorProviderName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderName.Icon")));
            // 
            // errorProviderSurname
            // 
            this.errorProviderSurname.ContainerControl = this;
            this.errorProviderSurname.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderSurname.Icon")));
            // 
            // errorProviderExperience
            // 
            this.errorProviderExperience.ContainerControl = this;
            this.errorProviderExperience.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderExperience.Icon")));
            // 
            // errorProviderEducation
            // 
            this.errorProviderEducation.ContainerControl = this;
            this.errorProviderEducation.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderEducation.Icon")));
            // 
            // errorProviderWaste
            // 
            this.errorProviderWaste.ContainerControl = this;
            this.errorProviderWaste.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderWaste.Icon")));
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
            // 
            // errorProviderPosition
            // 
            this.errorProviderPosition.ContainerControl = this;
            this.errorProviderPosition.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPosition.Icon")));
            // 
            // ListEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.panelMain);
            this.Name = "ListEmployeeControl";
            this.Size = new System.Drawing.Size(177, 228);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxEducation.ResumeLayout(false);
            this.groupBoxPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
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
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderSurname;
        private System.Windows.Forms.ErrorProvider errorProviderExperience;
        private System.Windows.Forms.ErrorProvider errorProviderEducation;
        private System.Windows.Forms.ErrorProvider errorProviderWaste;
        private System.Windows.Forms.ToolTip toolTipWarning;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.ErrorProvider errorProviderPosition;

    }
}
