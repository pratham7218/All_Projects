using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Stack_Oprations
{
    class Stack
    {
        internal ArrayList list = new ArrayList();
        internal void Push(object obj)
        {
            try
            {
                if (obj is null)
                {
                    throw new InvalidOperationException("Oopss...!!! Null can't be added to stack....");
                }
                else
                {
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
        
       internal object Pop()
        {
            object returned = null;
            try
            {
                if (list.Count == 0)
                {
                    throw new InvalidOperationException("Oopsss...!!! You are trying to pop elements from empty stack...");
                }
                else
                {
                    returned = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returned;
        }


       internal void Clear()
        {
            list = new ArrayList();
        }
    }
}
