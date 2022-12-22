using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Diary.xaml
    /// </summary>
    public partial class Diary : Window
    {
        public IDiaryInterface diary;
        public bool isOk { get; set; }

        string filePath = string.Empty;
        public Diary()
        {
            diary = new DiaryChecker();
            try
            {
                diary.loadData();
            }
            catch (Exception)
            {
            }

            InitializeComponent();
        }

        public Diary(string fPath)
        {
            diary = new DiaryChecker();

            try
            {
                diary.loadDataWithPath(fPath);
                isOk = true;
                filePath = fPath;
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден!");
                isOk = false;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат данных в файле!");
                isOk = false;
                return;
            }
            
            InitializeComponent();
        }

        private void StatiscticItemDiary_Click(object sender, RoutedEventArgs e)
        {
            Statistic windowStatistic = new Statistic(diary);
            windowStatistic.ShowDialog();
        }

        private void AddItemDiary_Click(object sender, RoutedEventArgs e)
        {
            AddTransaction windowTranscation = new AddTransaction(diary);
            windowTranscation.ShowDialog();
        }

        private void DiaryWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ListViewDiary.ItemsSource = diary.Diaries;
        }

        private void deleteItem_Click(object sender, RoutedEventArgs e)
        {
            DiaryBoss choosen = (DiaryBoss)ListViewDiary.SelectedItem;
            if (choosen == null)
                MessageBox.Show("Пожалуйста выберите строку, которую хотите удалить");
            else
                diary.Diaries.Remove(choosen);
        }

        private void editItem_Click(object sender, RoutedEventArgs e)
        {
            DiaryBoss choosen = (DiaryBoss)ListViewDiary.SelectedItem;
            if (choosen == null)
                MessageBox.Show("Пожалуйста выберите строку, которую хотите изменить");
            else
            {
                AddTransaction windowEditTransaction = new AddTransaction(diary, choosen);
                windowEditTransaction.ShowDialog();
            }
                
        }

        private void DiaryWindow_Closed(object sender, EventArgs e)
        {
            diary.saveData(filePath);
        }
    }
}
