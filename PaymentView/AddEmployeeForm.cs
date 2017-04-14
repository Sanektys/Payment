using System;
using System.Linq;
using System.Windows.Forms;
using PaymentData;

namespace PaymentView
{
    /// <summary>
    /// Форма добавления и редактирования данных о сотруднике
    /// </summary>
    public partial class AddEmployeeForm : Form
    {
        private bool _maskedName = false;
        private bool _maskedSurname = false;
        private bool _maskedWorkExperience = false;
        private bool _maskedEducation = false;
        private bool _maskedPosition = false;
        private bool _maskedHour = false;
        private bool _maskedRate = false;
        private bool _maskedSalary = false;

        public BasicEmployeeData Employee;

        public AddEmployeeForm(int id)
        {
            InitializeComponent();

            #if DEBUG
            buttonRandom.Visible = true;
            #endif

            labelHour.Visible = true;
            maskedHour.Visible = true;

            maskedName.Text = Listing.listEmployees.ElementAt(id).Name;
            _maskedName = true;
            maskedSurname.Text = Listing.listEmployees.ElementAt(id).Surname;
            _maskedSurname = true;
            maskedExperience.Text = Convert.ToString(Listing.listEmployees.ElementAt(id).WorkExperience);
            _maskedWorkExperience = true;
            switch (Listing.listEmployees.ElementAt(id).Position)
            {
                case Position.Workman: radioWorker.Checked = true; break;
                case Position.JuniorStaff: radioJunior.Checked = true; break;
                case Position.Engineer: radioEngineer.Checked = true; break;
                case Position.OfficeWorker: radioOffice.Checked = true; break;
            }
            _maskedPosition = true;
            switch (Listing.listEmployees.ElementAt(id).Education)
            {
                case Education.Missing: radioMissing.Checked = true; break;
                case Education.Secondary: radioSecondary.Checked = true; break;
                case Education.Higher: radioHigher.Checked = true; break;
            }
            _maskedEducation = true;
            HourlyPay hour = new HourlyPay();
            Rate rate = new Rate();
            Salary salary = new Salary();
            if (Listing.listEmployees.ElementAt(id).GetType() == hour.GetType())
            {
                radioHourlyPay.Checked = true;
                hour = (HourlyPay)Listing.listEmployees.ElementAt(id);
                maskedHour.Text = Convert.ToString(hour.HoursWorked);
                _maskedHour = true;
            }
            if (Listing.listEmployees.ElementAt(id).GetType() == rate.GetType())
            {
                radioRate.Checked = true;
                rate = (Rate)Listing.listEmployees.ElementAt(id);
                maskedRate.Text = Convert.ToString(rate.WorkedShift);
                _maskedRate = true;
            }
            if (Listing.listEmployees.ElementAt(id).GetType() == salary.GetType())
            {
                radioSalary.Checked = true;
                salary = (Salary)Listing.listEmployees.ElementAt(id);
                maskedSalary.Text = Convert.ToString(salary.SpentDays);
                _maskedSalary = true;
            }
        }

        public AddEmployeeForm()
        {
            InitializeComponent();

            #if DEBUG
            buttonRandom.Visible = true;
            #endif

            labelHour.Visible = true;
            maskedHour.Visible = true;
        }

        private void maskedExperience_MouseEnter(object sender, EventArgs e)
        {
            toolTipExperience.SetToolTip(maskedExperience, "не больше 80-ти лет");
        }

        private void maskedName_Enter(object sender, EventArgs e)
        {
            maskedName.SelectionStart = 0;
        }

        private void maskedName_MouseClick(object sender, MouseEventArgs e)
        {
            maskedName.SelectionStart = 0;
        }

        private void maskedSurname_MouseClick(object sender, MouseEventArgs e)
        {
            maskedSurname.SelectionStart = 0;
        }

        private void maskedExperience_MouseClick(object sender, MouseEventArgs e)
        {
            maskedExperience.SelectionStart = 0;
        }

        private void radioHourlyPay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHourlyPay.Checked)
            {
                labelHour.Visible = true;
                maskedHour.Visible = true;
            }
            else
            {
                labelHour.Visible = false;
                maskedHour.Visible = false;
                if (maskedHour.Text == "")
                {
                    _maskedHour = false;
                }
            }
        }

        private void maskedHour_MouseClick(object sender, MouseEventArgs e)
        {
            maskedHour.SelectionStart = 0;
        }

        private void maskedHour_MouseEnter(object sender, EventArgs e)
        {
            toolTipHour.SetToolTip(maskedHour, "не больше 176-ти часов");
        }

        private void radioRate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRate.Checked)
            {
                labelRate.Visible = true;
                maskedRate.Visible = true;
            }
            else
            {
                labelRate.Visible = false;
                maskedRate.Visible = false;
                if (maskedRate.Text == "")
                {
                    _maskedRate = false;
                }
            }
        }

        private void maskedRate_MouseClick(object sender, MouseEventArgs e)
        {
            maskedRate.SelectionStart = 0;
        }

        private void maskedRate_MouseEnter(object sender, EventArgs e)
        {
            toolTipHour.SetToolTip(maskedRate, "не больше 14-ти смен");
        }

        private void maskedSalary_MouseClick(object sender, MouseEventArgs e)
        {
            maskedSalary.SelectionStart = 0;
        }

        private void maskedSalary_MouseEnter(object sender, EventArgs e)
        {
            toolTipHour.SetToolTip(maskedSalary, "не больше 25-ти дней");
        }

        private void radioSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSalary.Checked)
            {
                labelSalary.Visible = true;
                maskedSalary.Visible = true;
            }
            else
            {
                labelSalary.Visible = false;
                maskedSalary.Visible = false;
                if (maskedSalary.Text == "")
                {
                    _maskedSalary = false;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int name = rand.Next(20);
            switch (name)
            {
                case 0: maskedName.Text = "Илья"; break;
                case 1: maskedName.Text = "Александр"; break;
                case 2: maskedName.Text = "Раиса"; break;
                case 3: maskedName.Text = "Маргарита"; break;
                case 4: maskedName.Text = "Владислав"; break;
                case 5: maskedName.Text = "Михаил"; break;
                case 6: maskedName.Text = "Ольга"; break;
                case 7: maskedName.Text = "Кирилл"; break;
                case 8: maskedName.Text = "Олег"; break;
                case 9: maskedName.Text = "Антон"; break;
                case 10: maskedName.Text = "Артур"; break;
                case 11: maskedName.Text = "Роман"; break;
                case 12: maskedName.Text = "Артём"; break;
                case 13: maskedName.Text = "Лариса"; break;
                case 14: maskedName.Text = "Вадим"; break;
                case 15: maskedName.Text = "Ира"; break;
                case 16: maskedName.Text = "Глеб"; break;
                case 17: maskedName.Text = "Егор"; break;
                case 18: maskedName.Text = "Константин"; break;
                case 19: maskedName.Text = "Лара"; break;
            }
            errorProviderName.Clear();
            _maskedName = true;

            int surname = rand.Next(20);
            switch (surname)
            {
                case 0: maskedSurname.Text = "Рабинович"; break;
                case 1: maskedSurname.Text = "Ким"; break;
                case 2: maskedSurname.Text = "Лебовски"; break;
                case 3: maskedSurname.Text = "Короленко"; break;
                case 4: maskedSurname.Text = "Букер"; break;
                case 5: maskedSurname.Text = "Грин"; break;
                case 6: maskedSurname.Text = "Миллер"; break;
                case 7: maskedSurname.Text = "Лот"; break;
                case 8: maskedSurname.Text = "Якобсон"; break;
                case 9: maskedSurname.Text = "Литман"; break;
                case 10: maskedSurname.Text = "Даль"; break;
                case 11: maskedSurname.Text = "Данильченко"; break;
                case 12: maskedSurname.Text = "Маричук"; break;
                case 13: maskedSurname.Text = "Божко"; break;
                case 14: maskedSurname.Text = "Холод"; break;
                case 15: maskedSurname.Text = "Станкевич"; break;
                case 16: maskedSurname.Text = "Шваровски"; break;
                case 17: maskedSurname.Text = "Коваленко"; break;
                case 18: maskedSurname.Text = "Тимошенко"; break;
                case 19: maskedSurname.Text = "Маркес"; break;
            }
            errorProviderSurname.Clear();
            _maskedSurname = true;

            maskedExperience.Text = Convert.ToString(rand.Next(1, 81));
            errorProviderExperience.Clear();
            _maskedWorkExperience = true;

            int position = rand.Next(4);
            switch (position)
            {
                case 0: radioWorker.Checked = true; break;
                case 1: radioJunior.Checked = true; break;
                case 2: radioEngineer.Checked = true; break;
                case 3: radioOffice.Checked = true; break;
            }
            _maskedPosition = true;
            
            int education = rand.Next(3);
            switch (education)
            {
                case 0: radioMissing.Checked = true; break;
                case 1: radioSecondary.Checked = true; break;
                case 2: radioHigher.Checked = true; break;
            }
            _maskedEducation = true;

            if (radioHourlyPay.Checked)
            {
                errorProviderPayment.Clear();
                maskedHour.Text = Convert.ToString(rand.Next(1, 177));
                _maskedHour = true;
            }
            if (radioRate.Checked)
            {
                errorProviderPayment.Clear();
                maskedRate.Text = Convert.ToString(rand.Next(1, 15));
                _maskedRate = true;
            }
            if (radioSalary.Checked)
            {
                errorProviderPayment.Clear();
                maskedSalary.Text = Convert.ToString(rand.Next(1, 26));
                _maskedSalary = true;
            }
        }

        private void maskedExperience_Leave(object sender, EventArgs e)
        {
            if (maskedExperience.Text == "")
            {
                errorProviderExperience.SetError(maskedExperience, "Пустое поле");
                _maskedWorkExperience = false;
            }
            else if (Convert.ToInt32(maskedExperience.Text) < 0 || Convert.ToInt32(maskedExperience.Text) > 80)
            {
                errorProviderExperience.SetError(maskedExperience, "Введено некорректное значение трудового стажа");
                _maskedWorkExperience = false;
            }
            else
            {
                errorProviderExperience.Clear();
                _maskedWorkExperience = true;
            }
        }

        private void maskedHour_Leave(object sender, EventArgs e)
        {
            if (maskedHour.Text == "")
            {
                errorProviderPayment.SetError(maskedHour, "Пустое поле");
                _maskedHour = false;
            }
            else if (Convert.ToInt32(maskedHour.Text) < 0 || Convert.ToInt32(maskedHour.Text) > 176)
            {
                errorProviderPayment.SetError(maskedHour, "Количество отработанных часов превышает норматив");
                _maskedHour = false;
            }
            else
            {
                errorProviderPayment.Clear();
                _maskedHour = true;
            }
        }

        private void maskedRate_Leave(object sender, EventArgs e)
        {
            if (maskedRate.Text == "")
            {
                errorProviderPayment.SetError(maskedRate, "Пустое поле");
                _maskedRate = false;
            }
            else if (Convert.ToInt32(maskedRate.Text) < 0 || Convert.ToInt32(maskedRate.Text) > 14)
            {
                errorProviderPayment.SetError(maskedRate, "Количество отработанных смен превышает норматив");
                _maskedRate = false;
            }
            else
            {
                errorProviderPayment.Clear();
                _maskedRate = true;
            }
        }

        private void maskedSalary_Leave(object sender, EventArgs e)
        {
            if (maskedSalary.Text == "")
            {
                errorProviderPayment.SetError(maskedSalary, "Пустое поле");
                _maskedSalary = false;
            }
            else if (Convert.ToInt32(maskedSalary.Text) < 0 || Convert.ToInt32(maskedSalary.Text) > 25)
            {
                errorProviderPayment.SetError(maskedSalary, "Количество отработанных дней превышает норматив");
                _maskedSalary = false;
            }
            else
            {
                errorProviderPayment.Clear();
                _maskedSalary = true;
            }
        }

        private void BaseData (BasicEmployeeData employee)
        {
            employee.Name = maskedName.Text;
            employee.Surname = maskedSurname.Text;
            employee.WorkExperience = Convert.ToInt32(maskedExperience.Text);
            if (radioWorker.Checked)
            {
                employee.Position = Position.Workman;
            }
            if (radioJunior.Checked)
            {
                employee.Position = Position.JuniorStaff;
            }
            if (radioEngineer.Checked)
            {
                employee.Position = Position.Engineer;
            }
            if (radioOffice.Checked)
            {
                employee.Position = Position.OfficeWorker;
            }
            if (radioMissing.Checked)
            {
                employee.Education = Education.Missing;
            }
            if (radioSecondary.Checked)
            {
                employee.Education = Education.Secondary;
            }
            if (radioHigher.Checked)
            {
                employee.Education = Education.Higher;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!(_maskedWorkExperience && _maskedName && _maskedSurname))
            {
                MessageBox.Show("Одно или несколько полей базовых данных введены неверно или пустуют", "Ошибка ввода");
            }
            else if (!(_maskedPosition && _maskedEducation))
            {
                MessageBox.Show("Не выбрана информация о должности или образовании", "Ошибка ввода");
            }
            else if (radioHourlyPay.Checked)
            {
                if (!_maskedHour)
                {
                    MessageBox.Show("Поле отработанных часов введено неверно или пустует", "Ошибка ввода");
                }
                else
                {
                    var employee = new HourlyPay();
                    BaseData(employee);
                    employee.HoursWorked = Convert.ToInt32(maskedHour.Text);
                    Employee = employee;
                    Close();
                }
            }
            else if (radioRate.Checked)
            {
                if (!_maskedRate)
                {
                    MessageBox.Show("Поле отработанных смен введено неверно или пустует", "Ошибка ввода");
                }
                else
                {
                    var employee = new Rate();
                    BaseData(employee);
                    employee.WorkedShift = Convert.ToInt32(maskedRate.Text);
                    Employee = employee;
                    Close();
                }
            }
            else if (radioSalary.Checked)
            {
                if (!_maskedSalary)
                {
                    MessageBox.Show("Поле отработанных дней введено неверно или пустует", "Ошибка ввода");
                }
                else
                {
                    var employee = new Salary();
                    BaseData(employee);
                    employee.SpentDays = Convert.ToInt32(maskedSalary.Text);
                    Employee = employee;
                    Close();
                }
            }
        }

        private void maskedName_Leave(object sender, EventArgs e)
        {
            if (maskedName.Text == "")
            {
                errorProviderName.SetError(maskedName, "Пустое поле");
                _maskedName = false;
            }
            else
            {
                errorProviderName.Clear();
                _maskedName = true;
            }
        }

        private void maskedSurname_Leave(object sender, EventArgs e)
        {
            if (maskedSurname.Text == "")
            {
                errorProviderSurname.SetError(maskedSurname, "Пустое поле");
                _maskedSurname = false;
            }
            else
            {
                errorProviderSurname.Clear();
                _maskedSurname = true;
            }
        }

        private void radioWorker_CheckedChanged(object sender, EventArgs e)
        {
            _maskedPosition = true;
        }

        private void radioJunior_CheckedChanged(object sender, EventArgs e)
        {
            _maskedPosition = true;
        }

        private void radioEngineer_CheckedChanged(object sender, EventArgs e)
        {
            _maskedPosition = true;
        }

        private void radioOffice_CheckedChanged(object sender, EventArgs e)
        {
            _maskedPosition = true;
        }

        private void radioSecondary_CheckedChanged(object sender, EventArgs e)
        {
            _maskedEducation = true;
        }

        private void radioHigher_CheckedChanged(object sender, EventArgs e)
        {
            _maskedEducation = true;
        }

        private void radioMissing_CheckedChanged(object sender, EventArgs e)
        {
            _maskedEducation = true;
        }
    }
}
