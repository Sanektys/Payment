using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public EditListsForm()
        {
            InitializeComponent();
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
            dataGridEmployee.Rows.Add(employee.Name, employee.Surname, employee.WorkExperience, employee.GetPosition, employee.GetEducation);
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
            }
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
            findForm.ShowDialog();
            if (Listing.findEmployees.Count == 0)
            {
                btnRemove.Visible = false;
                btnEdit.Visible = true;
                return;
            }
            dataGridEmployee.Rows.Clear();
            foreach (var data in Listing.findEmployees)
            {
                dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, data.GetPosition, data.GetEducation);
            }
            Listing.findEmployees.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridEmployee.Rows.Clear();
            foreach (var data in Listing.listEmployees)
            {
                dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, data.GetPosition, data.GetEducation);
            }
            btnRemove.Visible = false;
            btnEdit.Visible = true;
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
                    dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, data.GetPosition, data.GetEducation);
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
                dataGridEmployee.Rows.Add(data.Name, data.Surname, data.WorkExperience, data.GetPosition, data.GetEducation);
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
