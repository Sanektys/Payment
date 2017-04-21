using System;
using System.Drawing;
using System.Windows.Forms;
using PaymentData;

namespace PaymentView
{
    /// <summary>
    /// Элемент управления для ввода и вывода всех данных о сотруднике предприятия
    /// </summary>
    public partial class ListEmployeeControl : UserControl
    {
        public ListEmployeeControl()
        {
            InitializeComponent();
        }

        private bool _correctFields = false;
        private bool _readOnly;
        private TypeClass _typeClass;

        public bool DataValidity
        {
            get
            {
                maskedName_Leave(null, null);
                maskedSurname_Leave(null, null);
                maskedExperience_Leave(null, null);
                comboBoxPosition_Leave(null, null);
                comboBoxEducation_Leave(null, null);
                maskedWaste_Leave(null, null);
                FinalInspection();
                return _correctFields;
            }
            set
            {
                _correctFields = value;
                if (_correctFields)
                {
                    errorProviderName.Clear();
                    errorProviderSurname.Clear();
                    errorProviderExperience.Clear();
                    errorProviderPosition.Clear();
                    errorProviderEducation.Clear();
                    errorProviderWaste.Clear();
                }
            }
        }

        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                if (_readOnly)
                {
                    maskedName.ReadOnly = true;
                    maskedSurname.ReadOnly = true;
                    maskedExperience.ReadOnly = true;
                    comboBoxPosition.Visible = false;
                    groupBoxPosition.Size = new Size(156, 42);
                    labelPosition.Visible = true;
                    comboBoxEducation.Visible = false;
                    groupBoxEducation.Size = new Size(156, 42);
                    labelEducation.Visible = true;
                    maskedWaste.ReadOnly = true;
                    groupBoxPayment.Visible = true;
                    toolTipWarning.Active = false;
                    panelMain.Size = new Size(171, 223);
                }
                else
                {
                    maskedName.ReadOnly = false;
                    maskedSurname.ReadOnly = false;
                    maskedExperience.ReadOnly = false;
                    comboBoxPosition.Visible = true;
                    groupBoxPosition.Size = new Size(156, 45);
                    labelPosition.Visible = false;
                    comboBoxEducation.Visible = true;
                    groupBoxEducation.Size = new Size(156, 45);
                    labelEducation.Visible = false;
                    maskedWaste.ReadOnly = false;
                    groupBoxPayment.Visible = false;
                    toolTipWarning.Active = true;
                    panelMain.Size = new Size(171, 181);
                }
            }
        }

        public TypeClass TypeClass
        {
            get { return _typeClass; }
            set
            {
                _typeClass = value;
                TypeClassChange();
            }
        }

        public BasicEmployeeData BasicEmployeeData
        {
            get
            {              
                if (_typeClass == TypeClass.HourlyPay)
                {
                    var employee = new HourlyPay();
                    BaseEmployeeData(employee);
                    employee.HoursWorked = Convert.ToInt32(maskedWaste.Text);
                    return employee;
                }
                if (_typeClass == TypeClass.Rate)
                {
                    var employee = new Rate();
                    BaseEmployeeData(employee);
                    employee.WorkedShift = Convert.ToInt32(maskedWaste.Text);
                    return employee;
                }
                if (_typeClass == TypeClass.Salary)
                {
                    var employee = new Salary();
                    BaseEmployeeData(employee);
                    employee.SpentDays = Convert.ToInt32(maskedWaste.Text);
                    return employee;
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    maskedName.Text = null;
                    maskedSurname.Text = null;
                    maskedExperience.Text = null;
                    comboBoxPosition.SelectedItem = null;
                    labelPosition.Text = null;
                    comboBoxEducation.SelectedItem = null;
                    labelEducation.Text = null;
                    labelWaste.Text = "Отработанных...";
                    maskedWaste.Text = null;
                    labelPayment.Text = null;
                }
                else
                {
                    maskedName.Text = value.Name;
                    maskedSurname.Text = value.Surname;
                    maskedExperience.Text = Convert.ToString(value.WorkExperience);
                    switch (value.Position)
                    {
                        case Position.Engineer: comboBoxPosition.SelectedItem = comboBoxPosition.Items[0]; break;
                        case Position.JuniorStaff: comboBoxPosition.SelectedItem = comboBoxPosition.Items[1]; break;
                        case Position.OfficeWorker: comboBoxPosition.SelectedItem = comboBoxPosition.Items[2]; break;
                        case Position.Workman: comboBoxPosition.SelectedItem = comboBoxPosition.Items[3]; break;
                    }
                    labelPosition.Text = comboBoxPosition.Text;
                    switch (value.Education)
                    {
                        case Education.Missing: comboBoxEducation.SelectedItem = comboBoxEducation.Items[0]; break;
                        case Education.Secondary: comboBoxEducation.SelectedItem = comboBoxEducation.Items[1]; break;
                        case Education.Higher: comboBoxEducation.SelectedItem = comboBoxEducation.Items[2]; break;
                    }
                    labelEducation.Text = comboBoxEducation.Text;
                    if (value.GetType() == typeof(HourlyPay))
                    {
                        HourlyPay hourlyPay = (HourlyPay)value;
                        labelWaste.Text = "Отработанных часов:";
                        maskedWaste.Text = Convert.ToString(hourlyPay.HoursWorked);
                        labelPayment.Text = Convert.ToString(hourlyPay.FinalSalary()) + " ₽";
                    }
                    if (value.GetType() == typeof(Rate))
                    {
                        Rate rate = (Rate)value;
                        labelWaste.Text = "Отработанных смен:";
                        maskedWaste.Text = Convert.ToString(rate.WorkedShift);
                        labelPayment.Text = Convert.ToString(rate.FinalSalary()) + " ₽";
                    }
                    if (value.GetType() == typeof(Salary))
                    {
                        Salary salary = (Salary)value;
                        labelWaste.Text = "Отработанных дней:";
                        maskedWaste.Text = Convert.ToString(salary.SpentDays);
                        labelPayment.Text = Convert.ToString(salary.FinalSalary()) + " ₽";
                    }
                }
            }
        }

        private void BaseEmployeeData(BasicEmployeeData employee)
        {
            employee.Name = maskedName.Text;
            employee.Surname = maskedSurname.Text;
            employee.WorkExperience = Convert.ToInt32(maskedExperience.Text);
            switch (comboBoxPosition.SelectedIndex)
            {
                case 0: employee.Position = Position.Engineer; break;
                case 1: employee.Position = Position.JuniorStaff; break;
                case 2: employee.Position = Position.OfficeWorker; break;
                case 3: employee.Position = Position.Workman; break;
            }
            switch (comboBoxEducation.SelectedIndex)
            {
                case 0: employee.Education = Education.Missing; break;
                case 1: employee.Education = Education.Secondary; break;
                case 2: employee.Education = Education.Higher; break;
            }
        }

        private void TypeClassChange()
        {
            switch (_typeClass)
            {
                case TypeClass.HourlyPay: labelWaste.Text = "Отработанных часов:"; break;
                case TypeClass.Rate: labelWaste.Text = "Отработанных смен:"; break;
                case TypeClass.Salary: labelWaste.Text = "Отработанных дней:"; break;
            }
            if (!_readOnly && maskedWaste.Text != "")
            {
                maskedWaste_Leave(null, null);
            }
        }

        private void RemovalCarriage(object sender, System.EventArgs e)
        {
            if (_readOnly)
            {
                labelName.Focus();
            }
        }

        private void maskedName_Leave(object sender, EventArgs e)
        {
            if (maskedName.Text == "")
            {
                errorProviderName.SetError(maskedName, "Пустое поле");
            }
            else
            {
                errorProviderName.Clear();
            }
        }

        private void maskedSurname_Leave(object sender, EventArgs e)
        {
            if (maskedSurname.Text == "")
            {
                errorProviderSurname.SetError(maskedSurname, "Пустое поле");
            }
            else
            {
                errorProviderSurname.Clear();
            }
        }

        private void maskedExperience_Leave(object sender, EventArgs e)
        {
            if (maskedExperience.Text == "")
            {
                errorProviderExperience.SetError(labelExperience2, "Пустое поле");
            }
            else if (Convert.ToInt32(maskedExperience.Text) > 80)
            {
                errorProviderExperience.SetError(labelExperience2, "Введено некорректное значение трудового стажа");
            }
            else
            {
                errorProviderExperience.Clear();
            }
        }

        private void comboBoxPosition_Leave(object sender, EventArgs e)
        {
            if (comboBoxPosition.Text == "")
            {
                errorProviderPosition.SetError(groupBoxPosition, "Не выбрана должность сотрудника");
                errorProviderPosition.SetIconAlignment(groupBoxPosition, ErrorIconAlignment.TopRight);
                errorProviderPosition.SetIconPadding(groupBoxPosition, -12);
            }
            else
            {
                errorProviderPosition.Clear();
            }
        }

        private void comboBoxEducation_Leave(object sender, EventArgs e)
        {
            if (comboBoxEducation.Text == "")
            {
                errorProviderEducation.SetError(groupBoxEducation, "Не выбрано образование сотрудника");
                errorProviderEducation.SetIconAlignment(groupBoxEducation, ErrorIconAlignment.TopRight);
                errorProviderEducation.SetIconPadding(groupBoxEducation, -12);
            }
            else
            {
                errorProviderEducation.Clear();
            }
        }

        private void maskedWaste_Leave(object sender, EventArgs e)
        {
            if (maskedWaste.Text == "")
            {
                errorProviderWaste.SetError(maskedWaste, "Пустое поле");
            }
            else if (Convert.ToInt32(maskedWaste.Text) > 176 && _typeClass == TypeClass.HourlyPay)
            {
                errorProviderWaste.SetError(maskedWaste, "Количество отработанных часов превышает норматив");
            }
            else if (Convert.ToInt32(maskedWaste.Text) > 14 && _typeClass == TypeClass.Rate)
            {
                errorProviderWaste.SetError(maskedWaste, "Количество отработанных смен превышает норматив");
            }
            else if (Convert.ToInt32(maskedWaste.Text) > 25 && _typeClass == TypeClass.Salary)
            {
                errorProviderWaste.SetError(maskedWaste, "Количество отработанных дней превышает норматив");
            }
            else
            {
                errorProviderWaste.Clear();
            }
        }
        
        private void DefaultStartPosition(object sender, EventArgs e)
        {
            ((MaskedTextBox) sender).SelectionStart = 0;
        }

        private void FinalInspection()
        {
            if (!(errorProviderName.GetError(maskedName) == "" && errorProviderSurname.GetError(maskedSurname) == "" && errorProviderExperience.GetError(labelExperience2) == ""))
            {
                _correctFields = false;
                MessageBox.Show("Одно или несколько полей базовых данных введены неверно или пустуют", "Ошибка ввода");
            }
            else if (!(errorProviderPosition.GetError(groupBoxPosition) == "" && errorProviderEducation.GetError(groupBoxEducation) == ""))
            {
                _correctFields = false;
                MessageBox.Show("Не выбрана информация о должности или образовании", "Ошибка ввода");
            }
            else if (_typeClass == TypeClass.HourlyPay)
            {
                if (errorProviderWaste.GetError(maskedWaste) != "")
                {
                    _correctFields = false;
                    MessageBox.Show("Поле отработанных часов введено неверно или пустует", "Ошибка ввода");
                }
                else
                {
                    _correctFields = true;
                }
            }
            else if (_typeClass == TypeClass.Rate)
            {
                if (errorProviderWaste.GetError(maskedWaste) != "")
                {
                    _correctFields = false;
                    MessageBox.Show("Поле отработанных смен введено неверно или пустует", "Ошибка ввода");
                }
                else
                {
                    _correctFields = true; ;
                }
            }
            else if (_typeClass == TypeClass.Salary)
            {
                if (errorProviderWaste.GetError(maskedWaste) != "")
                {
                    _correctFields = false;
                    MessageBox.Show("Поле отработанных дней введено неверно или пустует", "Ошибка ввода");
                }
                else
                {
                    _correctFields = true;
                }
            }
        }

        private void maskedWaste_MouseEnter(object sender, EventArgs e)
        {
            switch (_typeClass)
            {
                case TypeClass.HourlyPay: toolTipWarning.SetToolTip(maskedWaste, "Не больше 176-ти часов"); break;
                case TypeClass.Rate: toolTipWarning.SetToolTip(maskedWaste, "Не больше 14-ти смен"); break;
                case TypeClass.Salary: toolTipWarning.SetToolTip(maskedWaste, "Не больше 25-ти дней"); break;
            }
        }
    }
}
