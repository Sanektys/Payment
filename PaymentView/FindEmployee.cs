using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PaymentData;

namespace PaymentView
{
    /// <summary>
    /// Форма поиска сотрудника по базовым критериям
    /// </summary>
    public partial class FindEmployee : Form
    {
        private bool _maskedWorkExperience = false;
        public FindEmployee()
        {
            InitializeComponent();

            IEnumerable<string> filterName =
                from data in Listing.listEmployees
                orderby data.Name
                select data.Name;
            foreach (var data in filterName.Distinct())
            {
                comboBoxName.Items.Add(data);
            }
            IEnumerable<string> filterSurname =
                from data in Listing.listEmployees
                orderby data.Surname
                select data.Surname;
            foreach (var data in filterSurname.Distinct())
            {
                comboBoxSurname.Items.Add(data);
            }
        }

        private void ButtonCheck()
        {
            if (radioButtonName.Checked || radioButtonSurname.Checked || radioButtonExperience.Checked || radioButtonPosition.Checked || radioButtonEducation.Checked)
            {
                Find.Enabled = true;
            }
            else
            {
                Find.Enabled = false;
            }
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonName.Checked)
            {
                comboBoxName.Enabled = true;
                Find.Enabled = true;
            }
            else
            {
                comboBoxName.Enabled = false;
                ButtonCheck();
            }
        }

        private void checkBoxSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSurname.Checked)
            {
                comboBoxSurname.Enabled = true;
                Find.Enabled = true;
            }
            else
            {
                comboBoxSurname.Enabled = false;
                ButtonCheck();
            }
        }

        private void checkBoxExperience_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExperience.Checked)
            {
                maskedExperience.Enabled = true;
                Find.Enabled = true;
            }
            else
            {
                maskedExperience.Enabled = false;
                ButtonCheck();
            }
        }

        private void checkBoxPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPosition.Checked)
            {
                comboBoxPosition.Enabled = true;
                Find.Enabled = true;
            }
            else
            {
                comboBoxPosition.Enabled = false;
                ButtonCheck();
            }
        }

        private void checkBoxEducation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEducation.Checked)
            {
                comboBoxEducation.Enabled = true;
                Find.Enabled = true;
            }
            else
            {
                comboBoxEducation.Enabled = false;
                ButtonCheck();
            }
        }

        private void maskedExperience_Leave(object sender, EventArgs e)
        {
            if (maskedExperience.Text == "")
            {
                errorExperience.SetError(maskedExperience, "Пустое поле");
                _maskedWorkExperience = false;
            }
            else if (Convert.ToInt32(maskedExperience.Text) < 0 || Convert.ToInt32(maskedExperience.Text) > 80)
            {
                errorExperience.SetError(maskedExperience, "Введено некорректное значение трудового стажа");
                _maskedWorkExperience = false;
            }
            else
            {
                errorExperience.Clear();
                _maskedWorkExperience = true;
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (radioButtonExperience.Checked)
            {
                if (!(_maskedWorkExperience))
                {
                    MessageBox.Show("Стаж введён неверно или пустует", "Ошибка ввода");
                    errorExperience.SetError(maskedExperience, "Исправьте поле");
                    return;
                }
            }
            if (radioButtonName.Checked)
            {
                if (comboBoxName.SelectedItem == null)
                {
                    MessageBox.Show("Поле имени пустует", "Ошибка заполнения");
                    return;
                }
                Listing.findEmployees.AddRange(Listing.listEmployees.Where(i => i.Name == Convert.ToString(comboBoxName.SelectedItem)));
            }
            if (radioButtonSurname.Checked)
            {
                if (comboBoxSurname.SelectedItem == null)
                {
                    MessageBox.Show("Поле фамилии пустует", "Ошибка заполнения");
                    return;
                }
                Listing.findEmployees.AddRange(Listing.listEmployees.Where(i => i.Surname == Convert.ToString(comboBoxSurname.SelectedItem)));
            }
            if (radioButtonExperience.Checked)
            {
                Listing.findEmployees.AddRange(Listing.listEmployees.Where(i => i.WorkExperience >= Convert.ToInt32(maskedExperience.Text)));
                if (Listing.findEmployees.Count == 0)
                {
                    MessageBox.Show("Сотрудники с такими данными отсутствуют", "Ошибка поиска");
                    return;
                }
            }
            if (radioButtonPosition.Checked)
            {
                if (comboBoxPosition.SelectedItem == null)
                {
                    MessageBox.Show("Поле должности пустует", "Ошибка заполнения");
                    return;
                }
                Listing.findEmployees.AddRange(Listing.listEmployees.Where(i => EditListsForm.GetPosition(i.Position) == Convert.ToString(comboBoxPosition.SelectedItem)));
                if (Listing.findEmployees.Count == 0)
                {
                    MessageBox.Show("Сотрудники с такими данными отсутствуют", "Ошибка поиска");
                    return;
                }
            }
            if (radioButtonEducation.Checked)
            {
                if (comboBoxEducation.SelectedItem == null)
                {
                    MessageBox.Show("Поле образования пустует", "Ошибка заполнения");
                    return;
                }
                Listing.findEmployees.AddRange(Listing.listEmployees.Where(i => EditListsForm.GetEducation(i.Education) == Convert.ToString(comboBoxEducation.SelectedItem)));
                if (Listing.findEmployees.Count == 0)
                {
                    MessageBox.Show("Сотрудники с такими данными отсутствуют", "Ошибка поиска");
                    return;
                }
            }
            Close();
        }

        private void maskedExperience_MouseEnter(object sender, EventArgs e)
        {
            toolTipExperience.SetToolTip(maskedExperience, "не больше 80-ти лет");
        }

        private void maskedExperience_MouseClick(object sender, MouseEventArgs e)
        {
            maskedExperience.SelectionStart = 0;
        }
    }
}
