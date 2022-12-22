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
    /// Логика взаимодействия для AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        bool flag = false;
        IDiaryInterface diary1, diary2;
        DiaryBoss ediTransaction;
        public AddTransaction(IDiaryInterface diary)
        {
            diary1 = diary;
            InitializeComponent();
            DatePickerTransaction.DisplayDateEnd = DateTime.Now;
        }
        public AddTransaction(IDiaryInterface diary, DiaryBoss editTransaction)
        {
            InitializeComponent();
            ediTransaction = editTransaction;
            TokenBoxTranscation.Text = editTransaction.Token;
            DatePickerTransaction.Text = editTransaction.TransactionDate.ToString();
            TypeComboTranscation.Text = editTransaction.TypeOfTransaction;
            QuantityBoxTransaction.Text = editTransaction.Quantity.ToString();
            EntryPriceBoxTranscation.Text= editTransaction.EntryPrice.ToString();
            ClosingPriceBoxTranscation.Text = editTransaction.ClosingPrice.ToString();
            ComissionBoxTranscation.Text = editTransaction.Commission.ToString();
            CommentsBoxTransaction.Text = editTransaction.Comment.ToString();
            diary2 = diary;
        }

        private void SaveButtonTranscation_Click(object sender, RoutedEventArgs e)
        {
            
            if (flag == false)
            {
                MessageBox.Show("Перед сохранением проверьте корректность данных и не забывайте про комментарий :)");
                flag = true;
            }

            DiaryBoss transaction = new DiaryBoss();


            try
            {
                transaction.Token = TokenBoxTranscation.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (DatePickerTransaction.Text == "")
                    throw new Exception();

                transaction.TransactionDate = DateTime.Parse(DatePickerTransaction.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Выберите дату сделки");
                return;
            }

            try
            {
                if (TypeComboTranscation.Text == "")
                {
                    throw new Exception();
                }
                transaction.TypeOfTransaction = TypeComboTranscation.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите тип сделки");
                return;
            }

            try
            {   
                transaction.Quantity = double.Parse(QuantityBoxTransaction.Text.Replace(".", ","));
                if (transaction.Quantity <= 0)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Количество лотов должно быть положительным числом");
                return;
            }

            try
            {
                transaction.EntryPrice = double.Parse(EntryPriceBoxTranscation.Text.Replace(".", ","));
                if (transaction.EntryPrice <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Цена открытия сделки должна быть положительным числом");
                return;
            }

            try
            {
                transaction.ClosingPrice = double.Parse(ClosingPriceBoxTranscation.Text.Replace(".", ","));
                if (transaction.ClosingPrice <= 0) 
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Цена закрытия сделки должна быть положительным числом");
                return;
            }

            try
            {
                transaction.Commission = double.Parse(ComissionBoxTranscation.Text.Replace(".", ","));
                if (transaction.Commission < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Комиссия должна быть положительным числом или нулём");
                return;
            }

            transaction.Comment = CommentsBoxTransaction.Text;

            if (diary1 != null) 
            {
                diary1.addTransactions(transaction); 
            }

            if (diary2 != null)
            {
                diary2.edit(ediTransaction, transaction);
            }

            Close();
        }
    }
}
