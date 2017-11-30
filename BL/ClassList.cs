using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
     public class ClassList
    {
        public List<int> List { get; set; }

        public ClassList(List<int> list)
        {
            this.List = list;
        }

        public void Process()
        {

            for (int i = 0; i < List.Count / 2; i++)
            {
                int c = List[i];
                List[i] = List[List.Count - 1 - i];
                List[List.Count - 1 - i] = c;
            }
        }

    }
}
