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

        public  List<int> Process()
        {
            List<int> list2 = new List<int>();
            for (int i = 0; i < List.Count; i++)
                list2.Add(List[i]);

            for (int i = 0; i < list2.Count / 2; i++)
            {
                int c = list2[i];
                list2[i] = list2[list2.Count - 1 - i];
                list2[list2.Count - 1 - i] = c;
            }
            return list2;
        }

    }
}
