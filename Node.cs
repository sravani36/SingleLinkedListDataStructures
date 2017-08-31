using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject1
{
    class Node
    {
        public int info;/* Actual Data which is stored in the List*/
        public Node link;/*Link which refers to next node*/
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}
