using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter12
{
    public class randomNumbers
    {
        public int randomNum { get; set; }
    }
    public class addNumbers
    {
        private List<randomNumbers> listNumbers;
        public addNumbers()
        {
            listNumbers = new List<randomNumbers>();
            for (int i = 1; i < 10; i++)
            {
                listNumbers.Add(new randomNumbers() { randomNum = i });
            }
        }
        public List<randomNumbers> returnList()
        {            
            return listNumbers;
        }
    }
}
