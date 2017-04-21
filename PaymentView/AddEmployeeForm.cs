using System;
using System.Drawing;
using System.Windows.Forms;
using PaymentData;

namespace PaymentView
{
    /// <summary>
    /// Форма добавления и редактирования данных о сотруднике
    /// </summary>
    public partial class AddEmployeeForm : Form
    {
        private ListEmployeeControl listEmployeeControlAdd = new ListEmployeeControl();
        
        public BasicEmployeeData Employee;

        public AddEmployeeForm(int id)
        {
            InitializeComponent();

            listEmployeeControlAdd.Parent = this;
            listEmployeeControlAdd.Location = new Point(5, 5);
            if (Listing.listEmployees[id].GetType() == typeof(HourlyPay))
            {
                radioHourlyPay.PerformClick();
                radioHourlyPay.Checked = true;
            }
            if (Listing.listEmployees[id].GetType() == typeof(Rate))
            {
                radioRate.PerformClick();
                radioRate.Checked = true;
            }
            if (Listing.listEmployees[id].GetType() == typeof(Salary))
            {
                radioSalary.PerformClick();
                radioSalary.Checked = true;
            }
            listEmployeeControlAdd.BasicEmployeeData = Listing.listEmployees[id];
            listEmployeeControlAdd.DataValidity = true;
            listEmployeeControlAdd.ReadOnly = false;

            #if DEBUG
            buttonRandom.Visible = true;
            #endif
        }

        public AddEmployeeForm()
        {
            InitializeComponent();

            listEmployeeControlAdd.Parent = this;
            listEmployeeControlAdd.Location = new Point(5, 5);
            listEmployeeControlAdd.TypeClass = TypeClass.HourlyPay;
            listEmployeeControlAdd.DataValidity = true;
            listEmployeeControlAdd.ReadOnly = false;            

            #if DEBUG
            buttonRandom.Visible = true;
            #endif
        }

        private void radioHourlyPay_Click(object sender, EventArgs e)
        {
            listEmployeeControlAdd.TypeClass = TypeClass.HourlyPay;
        }

        private void radioRate_Click(object sender, EventArgs e)
        {
            listEmployeeControlAdd.TypeClass = TypeClass.Rate;
        }

        private void radioSalary_Click(object sender, EventArgs e)
        {
            listEmployeeControlAdd.TypeClass = TypeClass.Salary;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaseRandomData(BasicEmployeeData employee)
        {
            Random rand = new Random();
            int name = rand.Next(20);
            switch (name)
            {
                case 0: employee.Name = "Илья"; break;
                case 1: employee.Name = "Александр"; break;
                case 2: employee.Name = "Раиса"; break;
                case 3: employee.Name = "Маргарита"; break;
                case 4: employee.Name = "Владислав"; break;
                case 5: employee.Name = "Михаил"; break;
                case 6: employee.Name = "Ольга"; break;
                case 7: employee.Name = "Кирилл"; break;
                case 8: employee.Name = "Олег"; break;
                case 9: employee.Name = "Антон"; break;
                case 10: employee.Name = "Артур"; break;
                case 11: employee.Name = "Роман"; break;
                case 12: employee.Name = "Артём"; break;
                case 13: employee.Name = "Лариса"; break;
                case 14: employee.Name = "Вадим"; break;
                case 15: employee.Name = "Ира"; break;
                case 16: employee.Name = "Глеб"; break;
                case 17: employee.Name = "Егор"; break;
                case 18: employee.Name = "Константин"; break;
                case 19: employee.Name = "Лара"; break;
            }

            int surname = rand.Next(20);
            switch (surname)
            {
                case 0: employee.Surname = "Рабинович"; break;
                case 1: employee.Surname = "Ким"; break;
                case 2: employee.Surname = "Лебовски"; break;
                case 3: employee.Surname = "Короленко"; break;
                case 4: employee.Surname = "Букер"; break;
                case 5: employee.Surname = "Грин"; break;
                case 6: employee.Surname = "Миллер"; break;
                case 7: employee.Surname = "Лот"; break;
                case 8: employee.Surname = "Якобсон"; break;
                case 9: employee.Surname = "Литман"; break;
                case 10: employee.Surname = "Даль"; break;
                case 11: employee.Surname = "Данильченко"; break;
                case 12: employee.Surname = "Маричук"; break;
                case 13: employee.Surname = "Божко"; break;
                case 14: employee.Surname = "Холод"; break;
                case 15: employee.Surname = "Станкевич"; break;
                case 16: employee.Surname = "Шваровски"; break;
                case 17: employee.Surname = "Коваленко"; break;
                case 18: employee.Surname = "Тимошенко"; break;
                case 19: employee.Surname = "Маркес"; break;
            }

            employee.WorkExperience = rand.Next(1, 81);

            int position = rand.Next(4);
            switch (position)
            {
                case 0: employee.Position = Position.Workman; break;
                case 1: employee.Position = Position.JuniorStaff; break;
                case 2: employee.Position = Position.Engineer; break;
                case 3: employee.Position = Position.OfficeWorker; break;
            }

            int education = rand.Next(3);
            switch (education)
            {
                case 0: employee.Education = Education.Missing; break;
                case 1: employee.Education = Education.Secondary; break;
                case 2: employee.Education = Education.Higher; break;
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (radioHourlyPay.Checked)
            {
                var employee = new HourlyPay();
                BaseRandomData(employee);
                employee.HoursWorked = rand.Next(1, 177);
                listEmployeeControlAdd.BasicEmployeeData = employee;
            }
            if (radioRate.Checked)
            {
                var employee = new Rate();
                BaseRandomData(employee);
                employee.WorkedShift = rand.Next(1, 15);
                listEmployeeControlAdd.BasicEmployeeData = employee;
            }
            if (radioSalary.Checked)
            {
                var employee = new Salary();
                BaseRandomData(employee);
                employee.SpentDays = rand.Next(1, 26);
                listEmployeeControlAdd.BasicEmployeeData = employee;
            }
            listEmployeeControlAdd.DataValidity = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (listEmployeeControlAdd.DataValidity)
            {
                Employee = listEmployeeControlAdd.BasicEmployeeData;
                Close();
            }
        }
    }
}
