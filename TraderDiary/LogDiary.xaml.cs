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
using Microsoft.Win32;

namespace TraderDiary
{
    /// <summary>
    /// Логика взаимодействия для LogDiary.xaml
    /// </summary>
    public partial class LogDiary : Window
    {
        private string pathToFile = string.Empty;
        public LogDiary()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            if (pathToFile == "") 
            {
                Diary windowDiary = new Diary();
                windowDiary.Owner = Window.GetWindow(this);
                MessageBox.Show("Так как Вы не выбрали документ, то будет использован TraderDiary.txt, находящийся в папке проекта");
                windowDiary.Show();
            }
            else if (pathToFile.Substring(pathToFile.Length - 3) == "txt")
            {
                Diary windowDiaryPath = new Diary(pathToFile);
                windowDiaryPath.Owner = Window.GetWindow(this);
                if (windowDiaryPath.isOk == true)
                {
                    windowDiaryPath.Show();
                }
            }
            else
            {
                Diary windowDiary1 = new Diary();
                windowDiary1.Owner = Window.GetWindow(this);
                MessageBox.Show("Так как Вы не выбрали документ, то будет использован TraderDiary.txt, находящийся в папке проекта");
                windowDiary1.Show();
            }
        }

        private void ChooseFileButton_Click(object sender, RoutedEventArgs e)
        {
            pathToFile = GetFileName();
        }

        private string GetFileName()
        {
            string fName = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Directory.GetParent(@"..\..\..\").FullName;
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text documents (.txt)|*.txt";
            openFileDialog.ShowDialog();
            fName = openFileDialog.FileName;

            if (fName == "")
            {
                fName = System.IO.Directory.GetParent(@"..\..\..\TraderDiary.txt").FullName;
            }
            return fName;
        }
    }
}
