using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Ödev1
{
    public class ArrayTypedStack : IStack
    {
        public object[] items;
        private int top = -1;
        public ArrayTypedStack(int itemCount)
        {
            this.items = new object[itemCount];
        }
        public void Push(object item)
        {
            if (items.Length == Top + 1)
            {
                //hata
            }
            else
                items[++Top] = item;
        }
        public object Pop()
        {
            if (IsEmpty())
            {
                //hata
            }
            object gecici = items[Top--];
            return gecici;
        }
        public object Peek()
        {
            return items[Top];
        }
        public bool IsEmpty()
        {
            return Top == -1;
        }
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
        public string DisplayElements()
        {
            string temp = "";
            for (int i = 0; i < items.Length; i++)
            {
                temp += "-->" + items[i];
            }
            return temp;
        }
        public int Search(int searchKey)
        {
            int baslangic = 0, bitis = items.GetUpperBound(0), orta = (baslangic + bitis) / 2;
            while ( baslangic <= bitis)
            {
                orta = (baslangic + bitis) / 2;
                if (Convert.ToInt32(items[orta]) > searchKey)
                    bitis = orta - 1;
                else if (Convert.ToInt32(items[orta]) < searchKey)
                    baslangic = orta + 1;
                else
                {
                    return orta;
                }
            }
            return -1;
        }
        public void quickSort(int altindis, int ustindis)
        {
            int yeni_altindis = altindis, yeni_ustindis = ustindis, h;
            int pivot = Convert.ToInt32(items[(altindis + ustindis) / 2]);

            do
            {
                while (Convert.ToInt32(items[yeni_altindis]) < pivot)
                    yeni_altindis++;
                while (Convert.ToInt32(items[yeni_ustindis]) > pivot)
                    yeni_ustindis--;
                if (yeni_altindis <= yeni_ustindis)
                {
                    h = Convert.ToInt32(items[yeni_altindis]);
                    items[yeni_altindis] = items[yeni_ustindis];
                    items[yeni_ustindis] = h;
                    yeni_altindis++;
                    yeni_ustindis--;
                }
            } while (yeni_altindis <= yeni_ustindis);
            if (altindis < yeni_ustindis)
                quickSort(altindis, yeni_ustindis);
            if (yeni_altindis < ustindis)
                quickSort(yeni_altindis, ustindis);
        }
    }
}

