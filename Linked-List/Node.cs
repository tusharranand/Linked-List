﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int Data)
        {
            this.Data = Data;
            Next = null;
        }
    }
}
