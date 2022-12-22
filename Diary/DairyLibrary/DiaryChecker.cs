using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace DiaryLibrary
{
    public class DiaryChecker: IDiaryInterface
    {   
        private ObservableCollection<DiaryBoss> transactions = new ObservableCollection<DiaryBoss>();
        private string fPath = @"..\..\..\TraderDiary.txt";

        public ObservableCollection<DiaryBoss> Diaries { get { return transactions; } }
        public List<string> Tokens { 
            get 
            {
                HashSet<String> tokens = new HashSet<string>();
                foreach (DiaryBoss token in Diaries)
                    tokens.Add(token.Token);
                return tokens.ToList();
            } 
        }

        public void addTransactions(DiaryBoss transaction)
        {
            transactions.Add(transaction);
            transactions.Sorting();
        }

        public void edit(DiaryBoss choosenTranscation, DiaryBoss editTransaction)
        {
            transactions.Remove(choosenTranscation);
            transactions.Add(editTransaction);
            transactions.Sorting();

        }
        public void loadData()
        {
            if (File.Exists(fPath))loadDataWithPath(fPath);
        }

        public void loadDataWithPath(string fPath) 
        {
            using (StreamReader reader = new StreamReader(new FileStream(fPath, FileMode.Open)))
            {
                string help;
                while ((help = reader.ReadLine()) != null)
                {
                    DiaryBoss transaction = new DiaryBoss();

                    transaction.Token = help;

                    help = reader.ReadLine();
                    transaction.TransactionDate = DateTime.Parse(help);

                    help = reader.ReadLine();
                    transaction.TypeOfTransaction = help;

                    help = reader.ReadLine();
                    transaction.Quantity = Convert.ToInt32(help);

                    help = reader.ReadLine();
                    transaction.EntryPrice = Convert.ToDouble(help);

                    help = reader.ReadLine();
                    transaction.ClosingPrice = Convert.ToDouble(help);

                    help = reader.ReadLine();
                    transaction.Commission = Convert.ToDouble(help, System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                    help = reader.ReadLine();
                    transaction.Comment = help;

                    addTransactions(transaction);
                }
            }
        }

        public void saveData(string filePath)
        {
            if (filePath == "")
            {
                filePath = fPath;
            }
            using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create)))
            {
                foreach (DiaryBoss transaction in transactions)
                    writer.Write(transaction);
            }
        }

        public void Statistic(string selectedToken, DateTime selectedStart, DateTime selectedEnd, string pathStat)
        {
            int quantityStat = 0;
            double cumulativeROE = 0;
            double profit = 0;
            string pathToSave = @"..\..\..\Отчёты\" + pathStat;

            foreach (DiaryBoss transaction in transactions)
            {
                if ((selectedToken == "Все токены") && (selectedStart <= transaction.TransactionDate) && (selectedEnd >= transaction.TransactionDate))
                { 
                    quantityStat++;
                    cumulativeROE += Convert.ToDouble((transaction.ROE).Substring(0, transaction.ROE.Length - 2));

                    if (transaction.TypeOfTransaction == "Long")
                    {
                        profit += ((transaction.ClosingPrice - transaction.EntryPrice) * transaction.Quantity - transaction.Commission);
                    }
                    else
                    {
                        profit += ((transaction.EntryPrice - transaction.ClosingPrice) * transaction.Quantity - transaction.Commission);
                    }

                }
                else if ((transaction.Token == selectedToken) && (selectedStart <= transaction.TransactionDate) && (selectedEnd >= transaction.TransactionDate))
                {
                    quantityStat++;
                    cumulativeROE += Convert.ToDouble((transaction.ROE).Substring(0, transaction.ROE.Length - 2));

                    if (transaction.TypeOfTransaction == "Long")
                    {
                        profit += ((transaction.ClosingPrice - transaction.EntryPrice) * transaction.Quantity - transaction.Commission);
                    }
                    else
                    {
                        profit += ((transaction.EntryPrice - transaction.ClosingPrice) * transaction.Quantity - transaction.Commission);
                    }

                }
            }
            
            if (quantityStat == 0)
            {
                throw new Exception();
            }

            using (StreamWriter writer = new StreamWriter(new FileStream(pathToSave, FileMode.Create)))
            {
                writer.Write("Отчёт за период с " + selectedStart.ToString("dd MMMM yyyy") + " по " + selectedEnd.ToString("dd MMMM yyyy") + "\n");
                writer.Write("Токен: " + selectedToken + "\n");
                writer.Write("Совершено сделок: " + quantityStat.ToString() + "\n");
                writer.Write("Совокупный ROE: " + cumulativeROE.ToString() + "%" + "\n");
                writer.Write("Совокупная прибыль: " + profit.ToString() + "\n");
            }
        }
    }
}
