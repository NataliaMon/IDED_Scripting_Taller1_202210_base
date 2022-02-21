using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = new Stack<int>();

            Stack<int> reverseStack = new Stack<int>();           
            int[] copyStackArray = sourceStack.ToArray();
            
            foreach(int element in copyStackArray)
            {
                reverseStack.Push(element);
            }

            int[] copyReverseStackArray = reverseStack.ToArray();
                        
            for (int i =0 ; i < copyReverseStackArray.Length-1; i++)
            {
                    int nextBigger = -1;

                    for (int j = i+1; j < copyReverseStackArray.Length; j++)
                    {
                        if (copyReverseStackArray[j] > copyReverseStackArray[i])
                        {
                            nextBigger = copyReverseStackArray[j];

                            break;
                        }                                        
                    }

               result.Push(nextBigger); 
            }

            result.Push(-1);

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();



            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = new Queue<Ticket>[3];

            result[0] = new Queue<Ticket>();
            result[1] = new Queue<Ticket>();
            result[2] = new Queue<Ticket>();

            sourceList.Sort(CompareTickets);

            foreach(Ticket ticket in sourceList)
            {
                if(ticket.RequestType == Ticket.ERequestType.Payment)
                {
                    result[0].Enqueue(ticket);
                }
                else if(ticket.RequestType == Ticket.ERequestType.Subscription)
                {
                    result[1].Enqueue(ticket);
                }
                else
                {
                    result[2].Enqueue(ticket);
                }
            }

            return result;
        }

        internal static int CompareTickets(Ticket a, Ticket b)
        {
            return a.Turn - b.Turn;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            if(targetQueue.Peek().RequestType == ticket.RequestType && ticket.Turn >= 0 && ticket.Turn <= 99)
            {
                targetQueue.Enqueue(ticket);
                result = true;
            }

            return result;
        }        
    }
}