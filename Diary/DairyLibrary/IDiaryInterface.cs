using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DiaryLibrary
{
    public interface IDiaryInterface
    {
        ObservableCollection<DiaryBoss> Diaries { get; }
        List<string> Tokens { get; }
        void addTransactions(DiaryBoss transaction);
        void edit(DiaryBoss choosenTransaction, DiaryBoss editTransaction);
        void loadData();
        void loadDataWithPath(string filePath);
        void saveData(string filePath);
        void Statistic(string selectedToken, DateTime selectedStart, DateTime selectedEnd, string pathStat);

    }
}
