using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using PaymentData;

namespace PaymentView
{
    /// <summary>
    /// Форма вывода списка сотрудников и манипуляции с ними
    /// </summary>
    public partial class EditListsForm : Form
    {
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<BasicEmployeeData>));

        private bool _find = false;

        public EditListsForm()
        {
            InitializeComponent();
        }

        public static string GetPosition(Position position)
        {
            switch (position)
            {
                case PaymentData.Position.Workman: return "Рабочий";
                case PaymentData.Position.JuniorStaff: return "Младший сотрудник";
                case PaymentData.Position.Engineer: return "Инженер";
                case PaymentData.Position.OfficeWorker: return "Офисный сотрудник";
            }
            return null;
        }

        public static string GetEducation(Education education)
        {
            switch (education)
            {
                case PaymentData.Education.Missing: return "Отсутствует";
                case PaymentData.Education.Secondary: return "Среднее";
                case PaymentData.Education.Higher: return "Высшее";
            }
            return null;
        }

        private void add_Click(object sender, EventArgs e)
        {          
            AddEmployeeForm addForm = new AddEmployeeForm();
            addForm.ShowDialog();
            var employee = addForm.Employee;
            if (employee == null)
            {
                return;
            }
            dataGridEmployee.Rows.Add(employee.Name, employee.Surname, employee.WorkExperience, GetPosition(employee.Position), GetEducation(employee.Education));
            Listing.listEmployees.Add(employee);
            remove.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int removeId = dataGridEmployee.SelectedCells[0].RowIndex;
            dataGridEmployee.Rows.RemoveAt(removeId);
            Listing.listEmployees.RemoveAt(removeId);           
            if (Listing.listEmployees.Count == 0)
            {
                remove.Enabled = false;
                btnEdit.Enabled = false;
                return;
            }
            dataGridEmployee.Rows[dataGridEmployee.SelectedCells[0].RowIndex].Selected = true;
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Listing.listEmployees.Count == 0)
            {
                MessageBox.Show("Список сотрудников пуст", "Ошибка поиска");
                return;
            }
            FindEmployee findForm = new FindEmployee();
            btnEdit.Visible = false;
            btnRemove.Visible = true;
            remove.Enabled = false;
            add.Enabled = false;
            findForm.ShowDialog();
            if (Listing.findEmployees.Count == 0)
            {
                if (_find == true)
                {
                    return;
                }
                btnRemove.Visible = false;
                btnEdit.Visible = true;
                remove.Enabled = true;
                add.Enabled = true;
                return;
            }
            dataGridEmployee.Rows.Clear();
            foreach (var data in Listing.findEmployees)
            {
                dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, GetPosition(data.Position), GetEducation(data.Education));
            }
            Listing.findEmployees.Clear();
            _find = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridEmployee.Rows.Clear();
            foreach (var data in Listing.listEmployees)
            {
                dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, GetPosition(data.Position), GetEducation(data.Education));
            }
            btnRemove.Visible = false;
            btnEdit.Visible = true;
            remove.Enabled = true;
            add.Enabled = true;
            _find = false;
        }

        private void ntcnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Списки сотрудников (.pmt)|*.pmt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream source = new FileStream(openFile.FileName, FileMode.OpenOrCreate))
                {
                    Listing.listEmployees = (List<BasicEmployeeData>)serializer.ReadObject(source);
                }  
                dataGridEmployee.Rows.Clear();
                foreach (var data in Listing.listEmployees)
                {
                    dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, GetPosition(data.Position), GetEducation(data.Education));
                }
                if (Listing.listEmployees.Count == 0)
                {
                    remove.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    remove.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Listing.listEmployees.Count == 0)
            {
                MessageBox.Show("Список сотрудников пуст", "Ошибка сохранения");
                return;
            }
            saveFile.Filter = "Списки сотрудников (.pmt)|*.pmt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream source = new FileStream(saveFile.FileName, FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(source, Listing.listEmployees);
                }  
                MessageBox.Show("Список успешно сохранён");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int row = dataGridEmployee.SelectedCells[0].RowIndex;
            int column = dataGridEmployee.SelectedCells[0].ColumnIndex;
            AddEmployeeForm editForm = new AddEmployeeForm(row);
            editForm.ShowDialog();
            var employee = editForm.Employee;           
            if (employee == null)
            {
                return;
            }
            Listing.listEmployees.Insert(row, employee);
            Listing.listEmployees.RemoveAt(row + 1);
            dataGridEmployee.Rows.Clear();
            foreach (var data in Listing.listEmployees)
            {
                dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, GetPosition(data.Position), GetEducation(data.Education));
            }
            dataGridEmployee.CurrentCell = dataGridEmployee.Rows[row].Cells[column];
            dataGridEmployee.Rows[row].Selected = true;
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridEmployee.Rows[dataGridEmployee.SelectedCells[0].RowIndex].Selected = true;
        }
    }
}
