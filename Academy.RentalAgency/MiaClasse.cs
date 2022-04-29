using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchLegacy
{
    public class MiaClasse : IDisposable
    {

        private int[] MyArray;
        public MiaClasse(int[] myArray)
        {
            MyArray = myArray;
        }

        public int Sum()
        {
            int result = 0;
            foreach (var item in MyArray)
            {
                result += item;
            }
            return result;
        }


        public void Dispose()
        {
            MyArray = null;
        }
    }
}