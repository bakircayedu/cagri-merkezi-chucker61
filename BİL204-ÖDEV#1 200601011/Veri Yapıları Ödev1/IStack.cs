using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Ödev1
{
    public interface IStack
    {
        
        void quickSort(int altindis, int ustindis);
        int Search(int searchKey);
        void Push(object item);
        object Pop();
        object Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}
