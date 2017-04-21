namespace PaymentView
{
    partial class FindEmployee
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
            this.components = new System.ComponentModel.Container();
            this.maskedExperience = new System.Windows.Forms.MaskedTextBox();
            this.Find = new System.Windows.Forms.Button();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.groupBoxExperience = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipExperience = new System.Windows.Forms.ToolTip(this.components);
            this.errorExperience = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonSurname = new System.Windows.Forms.RadioButton();
            this.groupBoxSurname = new System.Windows.Forms.GroupBox();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.radioButtonExperience = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation = new System.Windows.Forms.RadioButton();
            this.radioButtonPosition = new System.Windows.Forms.RadioButton();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.groupBoxEducation = new System.Windows.Forms.GroupBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.groupBoxName.SuspendLayout();
            this.groupBoxExperience.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorExperience)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxSurname.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.groupBoxEducation.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedExperience
            // 
            this.maskedExperience.BeepOnError = true;
            this.maskedExperience.Enabled = false;
            this.maskedExperience.Location = new System.Drawing.Point(30, 19);
            this.maskedExperience.Mask = "00";
            this.maskedExperience.Name = "maskedExperience";
            this.maskedExperience.Size = new System.Drawing.Size(18, 20);
            this.maskedExperience.TabIndex = 0;
            this.maskedExperience.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedExperience_MouseClick);
            this.maskedExperience.Leave += new System.EventHandler(this.maskedExperience_Leave);
            this.maskedExperience.MouseEnter += new System.EventHandler(this.maskedExperience_MouseEnter);
            // 
            // Find
            // 
            this.Find.Enabled = false;
            this.Find.Location = new System.Drawing.Point(108, 111);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 10;
            this.Find.Text = "Поиск";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.comboBoxName);
            this.groupBoxName.Location = new System.Drawing.Point(3, 3);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxName.Size = new System.Drawing.Size(94, 47);
            this.groupBoxName.TabIndex = 11;
            this.groupBoxName.TabStop = false;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.Enabled = false;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(6, 18);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(82, 21);
            this.comboBoxName.TabIndex = 16;
            // 
            // groupBoxExperience
            // 
            this.groupBoxExperience.Controls.Add(this.label1);
            this.groupBoxExperience.Controls.Add(this.maskedExperience);
            this.groupBoxExperience.Location = new System.Drawing.Point(206, 3);
            this.groupBoxExperience.Name = "groupBoxExperience";
            this.groupBoxExperience.Size = new System.Drawing.Size(64, 47);
            this.groupBoxExperience.TabIndex = 13;
            this.groupBoxExperience.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "От";
            // 
            // errorExperience
            // 
            this.errorExperience.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonName);
            this.panel1.Controls.Add(this.radioButtonSurname);
            this.panel1.Controls.Add(this.groupBoxSurname);
            this.panel1.Controls.Add(this.radioButtonExperience);
            this.panel1.Controls.Add(this.groupBoxName);
            this.panel1.Controls.Add(this.groupBoxExperience);
            this.panel1.Controls.Add(this.radioButtonEducation);
            this.panel1.Controls.Add(this.radioButtonPosition);
            this.panel1.Controls.Add(this.groupBoxPosition);
            this.panel1.Controls.Add(this.groupBoxEducation);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 102);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonName.Location = new System.Drawing.Point(9, 1);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(47, 17);
            this.radioButtonName.TabIndex = 17;
            this.radioButtonName.Text = "Имя";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // radioButtonSurname
            // 
            this.radioButtonSurname.AutoSize = true;
            this.radioButtonSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSurname.Location = new System.Drawing.Point(109, 1);
            this.radioButtonSurname.Name = "radioButtonSurname";
            this.radioButtonSurname.Size = new System.Drawing.Size(74, 17);
            this.radioButtonSurname.TabIndex = 18;
            this.radioButtonSurname.Text = "Фамилия";
            this.radioButtonSurname.UseVisualStyleBackColor = true;
            this.radioButtonSurname.CheckedChanged += new System.EventHandler(this.checkBoxSurname_CheckedChanged);
            // 
            // groupBoxSurname
            // 
            this.groupBoxSurname.Controls.Add(this.comboBoxSurname);
            this.groupBoxSurname.Location = new System.Drawing.Point(103, 3);
            this.groupBoxSurname.Name = "groupBoxSurname";
            this.groupBoxSurname.Size = new System.Drawing.Size(97, 47);
            this.groupBoxSurname.TabIndex = 19;
            this.groupBoxSurname.TabStop = false;
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurname.Enabled = false;
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Location = new System.Drawing.Point(6, 18);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSurname.TabIndex = 17;
            // 
            // radioButtonExperience
            // 
            this.radioButtonExperience.AutoSize = true;
            this.radioButtonExperience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonExperience.Location = new System.Drawing.Point(212, 1);
            this.radioButtonExperience.Name = "radioButtonExperience";
            this.radioButtonExperience.Size = new System.Drawing.Size(51, 17);
            this.radioButtonExperience.TabIndex = 18;
            this.radioButtonExperience.Text = "Стаж";
            this.radioButtonExperience.UseVisualStyleBackColor = true;
            this.radioButtonExperience.CheckedChanged += new System.EventHandler(this.checkBoxExperience_CheckedChanged);
            // 
            // radioButtonEducation
            // 
            this.radioButtonEducation.AutoSize = true;
            this.radioButtonEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEducation.Location = new System.Drawing.Point(156, 48);
            this.radioButtonEducation.Name = "radioButtonEducation";
            this.radioButtonEducation.Size = new System.Drawing.Size(93, 17);
            this.radioButtonEducation.TabIndex = 21;
            this.radioButtonEducation.Text = "Образование";
            this.radioButtonEducation.UseVisualStyleBackColor = true;
            this.radioButtonEducation.CheckedChanged += new System.EventHandler(this.checkBoxEducation_CheckedChanged);
            // 
            // radioButtonPosition
            // 
            this.radioButtonPosition.AutoSize = true;
            this.radioButtonPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonPosition.Location = new System.Drawing.Point(9, 48);
            this.radioButtonPosition.Name = "radioButtonPosition";
            this.radioButtonPosition.Size = new System.Drawing.Size(83, 17);
            this.radioButtonPosition.TabIndex = 20;
            this.radioButtonPosition.Text = "Должность";
            this.radioButtonPosition.UseVisualStyleBackColor = true;
            this.radioButtonPosition.CheckedChanged += new System.EventHandler(this.checkBoxPosition_CheckedChanged);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.comboBoxPosition);
            this.groupBoxPosition.Location = new System.Drawing.Point(3, 49);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(141, 47);
            this.groupBoxPosition.TabIndex = 21;
            this.groupBoxPosition.TabStop = false;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Enabled = false;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Рабочий",
            "Младший сотрудник",
            "Инженер",
            "Офисный сотрудник"});
            this.comboBoxPosition.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(129, 21);
            this.comboBoxPosition.TabIndex = 2;
            // 
            // groupBoxEducation
            // 
            this.groupBoxEducation.Controls.Add(this.comboBoxEducation);
            this.groupBoxEducation.Location = new System.Drawing.Point(150, 49);
            this.groupBoxEducation.Name = "groupBoxEducation";
            this.groupBoxEducation.Size = new System.Drawing.Size(120, 47);
            this.groupBoxEducation.TabIndex = 22;
            this.groupBoxEducation.TabStop = false;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducation.Enabled = false;
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Items.AddRange(new object[] {
            "Отсутствует",
            "Среднее",
            "Высшее"});
            this.comboBoxEducation.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(108, 21);
            this.comboBoxEducation.TabIndex = 3;
            // 
            // FindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 137);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindEmployee";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск сотрудника";
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxExperience.ResumeLayout(false);
            this.groupBoxExperience.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorExperience)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSurname.ResumeLayout(false);
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxEducation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedExperience;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.GroupBox groupBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipExperience;
        private System.Windows.Forms.ErrorProvider errorExperience;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonSurname;
        private System.Windows.Forms.RadioButton radioButtonExperience;
        private System.Windows.Forms.GroupBox groupBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private System.Windows.Forms.RadioButton radioButtonPosition;
        private System.Windows.Forms.RadioButton radioButtonEducation;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.GroupBox groupBoxEducation;
        private System.Windows.Forms.ComboBox comboBoxEducation;
    }
}