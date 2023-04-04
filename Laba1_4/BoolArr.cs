using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_4
{
    internal class BoolArr
    {
        private bool[] arr;
        private bool res;
        public bool exception = false;
        public int counter = 0;
        // конструктор класу
        public BoolArr(int sizeOfArr)
        {
            arr = new bool[sizeOfArr];
        }
        // оголошення індексатору
        public bool this[int i]
        {
            get {

                if (i >= 0 && i < arr.Length)
                {
                    return !arr[i];
                }
                else
                {
                    exception = true;
                    return false;
                }
            }
            set
            {
                if (i >= 0 && i < arr.Length)
                {
                    arr[i] = value;
                }
            }
        }
        // властивість
        public bool Result
        {
            get
            { 
                for(int i = 0; i<arr.Length; i++)
                {
                    if (arr[i]==false)
                    {
                        counter++;
                    }
                }
                if(counter==0)
                {
                    res = false;
                    return res;
                }
                if(counter>=1)
                {
                    res = true;
                    return res;
                }
                else
                {
                    res = false;
                    return res;
                }
            }
            set
            {
                value = res;
            }
        }
    }
}
