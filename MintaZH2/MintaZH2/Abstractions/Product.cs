using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH2.Abstractions
{
    //1.- 6. feladat feladat
    public abstract class Product : Button
    {
        #region 2.feladat

        private string _title;

        public string Title
        {
            get { return _title; }
            set 
            { 
                
                _title = value;
                Text = _title; //4. feladat
            }
        }

        private int _calories;

        public int Calories
        {
            get { return _calories; }
            set 
            {
                _calories = value;
                Display(); //5. feladat
            }
        }

        #endregion

        public Product()
        {
            Width = 150; // 6. feladat
            Height = 50;
        }

        public abstract void Display(); // kötelező megírni a származtatott osztályban

        //public virtual void Display(); || jelen esetben kell neki egy alap érték mondjuk { MessageBox.Show("virtual")}, de mindkettő esetben override kell meghívásnál


    }
}
