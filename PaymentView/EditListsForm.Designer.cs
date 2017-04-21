namespace PaymentView
{
    partial class EditListsForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditListsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ntcnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.remove);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.dataGridEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(383, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список сотрудников";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(141, 225);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(141, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Сбросить поиск";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Enabled = false;
            this.remove.Location = new System.Drawing.Point(250, 225);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(127, 23);
            this.remove.TabIndex = 2;
            this.remove.Text = "Удалить сотрудника";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add.Location = new System.Drawing.Point(6, 225);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(127, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить сотрудника";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.AllowUserToAddRows = false;
            this.dataGridEmployee.AllowUserToDeleteRows = false;
            this.dataGridEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Surnames,
            this.Worked,
            this.Position,
            this.Education});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployee.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridEmployee.Location = new System.Drawing.Point(6, 19);
            this.dataGridEmployee.MultiSelect = false;
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridEmployee.RowHeadersVisible = false;
            this.dataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmployee.Size = new System.Drawing.Size(371, 200);
            this.dataGridEmployee.TabIndex = 0;
            this.dataGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployee_CellClick);
            // 
            // Names
            // 
            this.Names.FillWeight = 47.55435F;
            this.Names.HeaderText = "Имя";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 70;
            // 
            // Surnames
            // 
            this.Surnames.FillWeight = 96.55326F;
            this.Surnames.HeaderText = "Фамилия";
            this.Surnames.Name = "Surnames";
            this.Surnames.ReadOnly = true;
            this.Surnames.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Surnames.Width = 80;
            // 
            // Worked
            // 
            this.Worked.FillWeight = 100.6121F;
            this.Worked.HeaderText = "Стаж(лет)";
            this.Worked.Name = "Worked";
            this.Worked.ReadOnly = true;
            this.Worked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Worked.Width = 58;
            // 
            // Position
            // 
            this.Position.FillWeight = 119.0821F;
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Position.Width = 80;
            // 
            // Education
            // 
            this.Education.FillWeight = 136.1982F;
            this.Education.HeaderText = "Образование";
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            this.Education.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Education.Width = 80;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2,
            this.toolStripSeparator3});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(593, 23);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "Верхняя панель";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(7, 15);
            this.toolStripLabel1.Text = " ";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ntcnToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 20);
            this.toolStripDropDownButton1.Text = " Файл";
            // 
            // ntcnToolStripMenuItem
            // 
            this.ntcnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ntcnToolStripMenuItem.Image")));
            this.ntcnToolStripMenuItem.Name = "ntcnToolStripMenuItem";
            this.ntcnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ntcnToolStripMenuItem.Text = "Открыть";
            this.ntcnToolStripMenuItem.Click += new System.EventHandler(this.ntcnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem1.Text = "Сохранить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoToolTip = false;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripData,
            this.toolStripSeparator4,
            this.поискToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(71, 20);
            this.toolStripDropDownButton2.Text = " Список";
            // 
            // toolStripData
            // 
            this.toolStripData.CheckOnClick = true;
            this.toolStripData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripData.Image")));
            this.toolStripData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripData.Name = "toolStripData";
            this.toolStripData.Size = new System.Drawing.Size(200, 22);
            this.toolStripData.Text = "Показать подробности";
            this.toolStripData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripData.CheckedChanged += new System.EventHandler(this.toolStripData_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поискToolStripMenuItem.Image")));
            this.поискToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.поискToolStripMenuItem.Text = "Поиск сотрудников";
            this.поискToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // openFile
            // 
            this.openFile.Title = "Загрузка списка сотрудников";
            // 
            // saveFile
            // 
            this.saveFile.Title = "Сохранение списка сотрудников";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBoxData.Location = new System.Drawing.Point(395, 23);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(189, 255);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Информация о сотруднике";
            this.groupBoxData.Visible = false;
            // 
            // EditListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(593, 286);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 650);
            this.MinimumSize = new System.Drawing.Size(609, 325);
            this.Name = "EditListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списки по оплате";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ntcnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.ToolStripMenuItem toolStripData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surnames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
    }
}

