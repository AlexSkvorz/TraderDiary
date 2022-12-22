using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DiaryLibrary;

namespace TraderDiary
{
    /// <summary>
    /// Логика взаимодействия для Statistic.xaml
    /// </summary>
    public partial class Statistic : Window
    {
        public IDiaryInterface statistic;
        public Statistic(IDiaryInterface diary)
        {
            InitializeComponent();
            statistic = diary;
            DatePickerStartStat.DisplayDateEnd = DateTime.Now;
            DatePickerEndStat.DisplayDateEnd = DateTime.Now;
        }

        private void StatisticWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < statistic.Tokens.Count; i++)
                {
                    ComboBoxStat.Items.Add(statistic.Tokens[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл пустой");
            }
            ComboBoxStat.Items.Add("Все токены");
        }
        private void SaveButtonStat_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                if (ComboBoxStat.Text == "")
                {
                    MessageBox.Show("Выберите токен");
                    return;
                }
                else if (DatePickerStartStat.Text == "")
                {
                    MessageBox.Show("Выберите дату начала отчетного периода");
                    return;
                }
                else if (DatePickerEndStat.Text == "")
                {
                    MessageBox.Show("Выберите дату конца отчетного периода");
                    return;
                }

                else if (DateTime.Parse(DatePickerStartStat.Text) > DateTime.Parse(DatePickerEndStat.Text))
                {
                    MessageBox.Show("Дата начала отчетного периода не может быть позже даты конца");
                    return;
                }
                else if (FileNameBox.Text == "Month.txt" || FileNameBox.Text == "")
                {
                    FileNameBox.Text = ComboBoxStat.Text + " c " + DateTime.Parse(DatePickerStartStat.Text).ToString("dd MMMM yyyy") + " по " + DateTime.Parse(DatePickerEndStat.Text).ToString("dd MMMM yyyy") + ".txt";
                }
                else
                {
                    if (!(FileNameBox.Text).EndsWith(".txt"))
                    {
                        FileNameBox.Text += ".txt";
                    }
                }

            }
            catch { }
            try
            {
                statistic.Statistic(ComboBoxStat.Text, DateTime.Parse(DatePickerStartStat.Text), DateTime.Parse(DatePickerEndStat.Text), FileNameBox.Text);
                MessageBox.Show("Файл " + FileNameBox.Text + " сохранен в папке Отчёты в корне проекта");
            }
            catch (Exception)
            {
                MessageBox.Show("За указанный период нет сделок, выберите другой диапозон дат");
            }
        }
    }
}
