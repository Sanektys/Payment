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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.maskedExperience = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedSurname = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxEducation = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioHigher = new System.Windows.Forms.RadioButton();
            this.radioMissing = new System.Windows.Forms.RadioButton();
            this.radioSecondary = new System.Windows.Forms.RadioButton();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.radioJunior = new System.Windows.Forms.RadioButton();
            this.radioOffice = new System.Windows.Forms.RadioButton();
            this.radioWorker = new System.Windows.Forms.RadioButton();
            this.radioEngineer = new System.Windows.Forms.RadioButton();
            this.panelOption = new System.Windows.Forms.Panel();
            this.maskedRate = new System.Windows.Forms.MaskedTextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.maskedHour = new System.Windows.Forms.MaskedTextBox();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.maskedSalary = new System.Windows.Forms.MaskedTextBox();
            this.toolTipExperience = new System.Windows.Forms.ToolTip(this.components);
            this.radioSalary = new System.Windows.Forms.RadioButton();
            this.radioRate = new System.Windows.Forms.RadioButton();
            this.radioHourlyPay = new System.Windows.Forms.RadioButton();
            this.toolTipHour = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderExperience = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPayment = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxEducation.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPayment)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).BeginInit();
            this.SuspendLayout();
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
            this.maskedExperience.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedExperience_MouseEnter);
            this.maskedExperience.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedExperience_MouseClick);
            this.maskedExperience.Leave += new System.EventHandler(this.maskedExperience_Leave);
            this.maskedExperience.MouseEnter += new System.EventHandler(this.maskedExperience_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Трудовой стаж:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя:";
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
            this.maskedName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedName_MouseClick);
            this.maskedName.Enter += new System.EventHandler(this.maskedName_Enter);
            this.maskedName.Leave += new System.EventHandler(this.maskedName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия:";
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
            this.maskedSurname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedSurname_MouseClick);
            this.maskedSurname.Leave += new System.EventHandler(this.maskedSurname_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.maskedName);
            this.panel1.Controls.Add(this.groupBoxEducation);
            this.panel1.Controls.Add(this.groupBoxPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelOption);
            this.panel1.Controls.Add(this.maskedExperience);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedSurname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 218);
            this.panel1.TabIndex = 11;
            // 
            // groupBoxEducation
            // 
            this.groupBoxEducation.Controls.Add(this.panel3);
            this.groupBoxEducation.Controls.Add(this.radioHigher);
            this.groupBoxEducation.Controls.Add(this.radioMissing);
            this.groupBoxEducation.Controls.Add(this.radioSecondary);
            this.groupBoxEducation.Location = new System.Drawing.Point(7, 129);
            this.groupBoxEducation.Name = "groupBoxEducation";
            this.groupBoxEducation.Size = new System.Drawing.Size(187, 59);
            this.groupBoxEducation.TabIndex = 20;
            this.groupBoxEducation.TabStop = false;
            this.groupBoxEducation.Text = "Имеющееся образование:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(94, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 19);
            this.panel3.TabIndex = 17;
            // 
            // radioHigher
            // 
            this.radioHigher.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHigher.Location = new System.Drawing.Point(93, 15);
            this.radioHigher.Margin = new System.Windows.Forms.Padding(0);
            this.radioHigher.Name = "radioHigher";
            this.radioHigher.Size = new System.Drawing.Size(92, 21);
            this.radioHigher.TabIndex = 3;
            this.radioHigher.TabStop = true;
            this.radioHigher.Text = "Высшее";
            this.radioHigher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioHigher.UseVisualStyleBackColor = true;
            this.radioHigher.CheckedChanged += new System.EventHandler(this.radioHigher_CheckedChanged);
            // 
            // radioMissing
            // 
            this.radioMissing.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMissing.Location = new System.Drawing.Point(2, 35);
            this.radioMissing.Margin = new System.Windows.Forms.Padding(0);
            this.radioMissing.Name = "radioMissing";
            this.radioMissing.Size = new System.Drawing.Size(92, 21);
            this.radioMissing.TabIndex = 2;
            this.radioMissing.TabStop = true;
            this.radioMissing.Text = "Отсутствует";
            this.radioMissing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMissing.UseVisualStyleBackColor = true;
            this.radioMissing.CheckedChanged += new System.EventHandler(this.radioMissing_CheckedChanged);
            // 
            // radioSecondary
            // 
            this.radioSecondary.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSecondary.Location = new System.Drawing.Point(2, 15);
            this.radioSecondary.Margin = new System.Windows.Forms.Padding(0);
            this.radioSecondary.Name = "radioSecondary";
            this.radioSecondary.Size = new System.Drawing.Size(92, 21);
            this.radioSecondary.TabIndex = 0;
            this.radioSecondary.TabStop = true;
            this.radioSecondary.Text = "Среднее";
            this.radioSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioSecondary.UseVisualStyleBackColor = true;
            this.radioSecondary.CheckedChanged += new System.EventHandler(this.radioSecondary_CheckedChanged);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.radioJunior);
            this.groupBoxPosition.Controls.Add(this.radioOffice);
            this.groupBoxPosition.Controls.Add(this.radioWorker);
            this.groupBoxPosition.Controls.Add(this.radioEngineer);
            this.groupBoxPosition.Location = new System.Drawing.Point(7, 65);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(187, 59);
            this.groupBoxPosition.TabIndex = 19;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Занимаемая должность:";
            // 
            // radioJunior
            // 
            this.radioJunior.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioJunior.Location = new System.Drawing.Point(93, 15);
            this.radioJunior.Margin = new System.Windows.Forms.Padding(0);
            this.radioJunior.Name = "radioJunior";
            this.radioJunior.Size = new System.Drawing.Size(92, 21);
            this.radioJunior.TabIndex = 11;
            this.radioJunior.TabStop = true;
            this.radioJunior.Text = "Младший сотр.";
            this.radioJunior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioJunior.UseVisualStyleBackColor = true;
            this.radioJunior.CheckedChanged += new System.EventHandler(this.radioJunior_CheckedChanged);
            // 
            // radioOffice
            // 
            this.radioOffice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOffice.Location = new System.Drawing.Point(93, 35);
            this.radioOffice.Margin = new System.Windows.Forms.Padding(0);
            this.radioOffice.Name = "radioOffice";
            this.radioOffice.Size = new System.Drawing.Size(92, 21);
            this.radioOffice.TabIndex = 18;
            this.radioOffice.TabStop = true;
            this.radioOffice.Text = "Офисный сотр.";
            this.radioOffice.UseVisualStyleBackColor = true;
            this.radioOffice.CheckedChanged += new System.EventHandler(this.radioOffice_CheckedChanged);
            // 
            // radioWorker
            // 
            this.radioWorker.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioWorker.Location = new System.Drawing.Point(2, 15);
            this.radioWorker.Margin = new System.Windows.Forms.Padding(0);
            this.radioWorker.Name = "radioWorker";
            this.radioWorker.Size = new System.Drawing.Size(92, 21);
            this.radioWorker.TabIndex = 10;
            this.radioWorker.TabStop = true;
            this.radioWorker.Text = "Рабочий";
            this.radioWorker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioWorker.UseVisualStyleBackColor = true;
            this.radioWorker.CheckedChanged += new System.EventHandler(this.radioWorker_CheckedChanged);
            // 
            // radioEngineer
            // 
            this.radioEngineer.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEngineer.Location = new System.Drawing.Point(2, 35);
            this.radioEngineer.Margin = new System.Windows.Forms.Padding(0);
            this.radioEngineer.Name = "radioEngineer";
            this.radioEngineer.Size = new System.Drawing.Size(92, 21);
            this.radioEngineer.TabIndex = 17;
            this.radioEngineer.TabStop = true;
            this.radioEngineer.Text = "Инженер";
            this.radioEngineer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioEngineer.UseVisualStyleBackColor = true;
            this.radioEngineer.CheckedChanged += new System.EventHandler(this.radioEngineer_CheckedChanged);
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelOption.Controls.Add(this.maskedRate);
            this.panelOption.Controls.Add(this.labelRate);
            this.panelOption.Controls.Add(this.maskedHour);
            this.panelOption.Controls.Add(this.labelHour);
            this.panelOption.Controls.Add(this.labelSalary);
            this.panelOption.Controls.Add(this.maskedSalary);
            this.panelOption.Location = new System.Drawing.Point(2, 189);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(166, 25);
            this.panelOption.TabIndex = 13;
            // 
            // maskedRate
            // 
            this.maskedRate.BackColor = System.Drawing.SystemColors.Control;
            this.maskedRate.BeepOnError = true;
            this.maskedRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedRate.Location = new System.Drawing.Point(115, 5);
            this.maskedRate.Mask = "00";
            this.maskedRate.Name = "maskedRate";
            this.maskedRate.Size = new System.Drawing.Size(14, 13);
            this.maskedRate.TabIndex = 3;
            this.maskedRate.Visible = false;
            this.maskedRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedRate_MouseClick);
            this.maskedRate.Leave += new System.EventHandler(this.maskedRate_Leave);
            this.maskedRate.MouseEnter += new System.EventHandler(this.maskedRate_MouseEnter);
            // 
            // labelRate
            // 
            this.labelRate.Location = new System.Drawing.Point(3, 5);
            this.labelRate.Margin = new System.Windows.Forms.Padding(0);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(112, 13);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "Отработанных смен:";
            this.labelRate.Visible = false;
            // 
            // maskedHour
            // 
            this.maskedHour.BackColor = System.Drawing.SystemColors.Control;
            this.maskedHour.BeepOnError = true;
            this.maskedHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedHour.Location = new System.Drawing.Point(116, 5);
            this.maskedHour.Mask = "000";
            this.maskedHour.Name = "maskedHour";
            this.maskedHour.Size = new System.Drawing.Size(21, 13);
            this.maskedHour.TabIndex = 1;
            this.maskedHour.Visible = false;
            this.maskedHour.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedHour_MouseClick);
            this.maskedHour.Leave += new System.EventHandler(this.maskedHour_Leave);
            this.maskedHour.MouseEnter += new System.EventHandler(this.maskedHour_MouseEnter);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(3, 5);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(115, 13);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "Отработанных часов:";
            this.labelHour.Visible = false;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(3, 5);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(110, 13);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Отработанных дней:";
            this.labelSalary.Visible = false;
            // 
            // maskedSalary
            // 
            this.maskedSalary.BackColor = System.Drawing.SystemColors.Control;
            this.maskedSalary.BeepOnError = true;
            this.maskedSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedSalary.Location = new System.Drawing.Point(113, 5);
            this.maskedSalary.Mask = "00";
            this.maskedSalary.Name = "maskedSalary";
            this.maskedSalary.Size = new System.Drawing.Size(15, 13);
            this.maskedSalary.TabIndex = 5;
            this.maskedSalary.Visible = false;
            this.maskedSalary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedSalary_MouseClick);
            this.maskedSalary.Leave += new System.EventHandler(this.maskedSalary_Leave);
            this.maskedSalary.MouseEnter += new System.EventHandler(this.maskedSalary_MouseEnter);
            // 
            // toolTipExperience
            // 
            this.toolTipExperience.AutomaticDelay = 100;
            this.toolTipExperience.AutoPopDelay = 10000;
            this.toolTipExperience.InitialDelay = 100;
            this.toolTipExperience.ReshowDelay = 20;
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
            this.radioSalary.CheckedChanged += new System.EventHandler(this.radioSalary_CheckedChanged);
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
            this.radioRate.CheckedChanged += new System.EventHandler(this.radioRate_CheckedChanged);
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
            this.radioHourlyPay.CheckedChanged += new System.EventHandler(this.radioHourlyPay_CheckedChanged);
            // 
            // toolTipHour
            // 
            this.toolTipHour.AutomaticDelay = 100;
            this.toolTipHour.AutoPopDelay = 10000;
            this.toolTipHour.InitialDelay = 100;
            this.toolTipHour.ReshowDelay = 20;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRandom.Location = new System.Drawing.Point(222, 101);
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
            this.buttonOk.Location = new System.Drawing.Point(222, 205);
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
            this.buttonCancel.Location = new System.Drawing.Point(288, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProviderExperience
            // 
            this.errorProviderExperience.ContainerControl = this;
            // 
            // errorProviderPayment
            // 
            this.errorProviderPayment.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.radioSalary);
            this.groupBox2.Controls.Add(this.radioHourlyPay);
            this.groupBox2.Controls.Add(this.radioRate);
            this.groupBox2.Location = new System.Drawing.Point(222, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 85);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метод оплаты";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderSurname
            // 
            this.errorProviderSurname.ContainerControl = this;
            // 
            // AddEmployeeForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(362, 238);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEmployeeForm";
            this.Opacity = 0.99D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить\\редактировать сотрудника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxEducation.ResumeLayout(false);
            this.groupBoxPosition.ResumeLayout(false);
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPayment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedExperience;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipExperience;
        private System.Windows.Forms.RadioButton radioSalary;
        private System.Windows.Forms.RadioButton radioRate;
        private System.Windows.Forms.RadioButton radioHourlyPay;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.MaskedTextBox maskedHour;
        private System.Windows.Forms.ToolTip toolTipHour;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.MaskedTextBox maskedRate;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.MaskedTextBox maskedSalary;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProviderExperience;
        private System.Windows.Forms.ErrorProvider errorProviderPayment;
        private System.Windows.Forms.RadioButton radioEngineer;
        private System.Windows.Forms.RadioButton radioJunior;
        private System.Windows.Forms.RadioButton radioWorker;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.RadioButton radioOffice;
        private System.Windows.Forms.GroupBox groupBoxEducation;
        private System.Windows.Forms.RadioButton radioMissing;
        private System.Windows.Forms.RadioButton radioSecondary;
        private System.Windows.Forms.RadioButton radioHigher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderSurname;
    }
}