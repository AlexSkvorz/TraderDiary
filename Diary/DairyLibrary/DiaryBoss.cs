using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DiaryLibrary
{
    public class DiaryBoss : IComparable<DiaryBoss>
    {
        private string token; 
        private DateTime transactionDate;
        private string typeOfTransaction;
        private double quantity;
        private double entryPrice;
        private double closingPrice;
        private double comission;
        private string roe;
        private string comment;

        public string Token
        {
            get { return token; }
            set
            {
                if (Regex.IsMatch(value.Substring(1, value.Length - 1), "^[a-zA-Z]*$") && (value[0] is '$'))
                {
                    token = value;
                }
                else
                {
                    throw new Exception("Токен должен начинаться со знака $ и состоять только из английских букв!");
                }
            }
        }
        public DateTime TransactionDate { get { return transactionDate; } set { transactionDate = value; } }
        
        public string TypeOfTransaction { get { return typeOfTransaction; } set { typeOfTransaction = value; } }

        public double Quantity { get { return quantity; } set { quantity = value; } }

        public double EntryPrice { get { return entryPrice; } set { entryPrice = value; } }

        public double ClosingPrice { get { return closingPrice; } set { closingPrice = value; } }

        public double Commission { get { return comission; } set { comission = value; } }

        public string ROE
        {   
            get {
                if (typeOfTransaction is "Short")
                {
                    roe = Convert.ToString(Math.Round(((entryPrice - closingPrice) * quantity - comission) / (entryPrice * quantity) * 100, 2));
                    roe += "%";
                    return roe;
                }
                else
                {
                    roe = Convert.ToString(Math.Round(((closingPrice - entryPrice) * quantity - comission) / (entryPrice * quantity) * 100, 2));
                    roe += "%";
                    return roe;
                }
            }
            set {
                roe = value;
            }
            
        }

        public string Comment { get { return comment; } set { comment = value; } }

        public int CompareTo(DiaryBoss date)
        {
            return TransactionDate.CompareTo(date.TransactionDate);
        }

        public override string ToString()
        {
            return token + "\n" + transactionDate.ToString("dd MMMM yyyy") + "\n" + typeOfTransaction + "\n" + quantity + "\n" + entryPrice + "\n" + closingPrice + "\n" + comission + "\n" + comment + "\n";
        }

    }


}
