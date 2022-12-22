using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    static class DateSort
    {
        public static void Sorting<T>(this ObservableCollection<T> diaries) where T : IComparable<T>
        {
            List<T> list = diaries.OrderBy(x => x).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                diaries.Move(diaries.IndexOf(list[i]), i);
            }
        }
    }
}
