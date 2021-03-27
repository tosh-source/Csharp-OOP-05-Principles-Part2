using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RangeException.Models
{
    class InvalidRangeException<T>
    {
        public string Start { get; private set; }
        public string End { get; private set; }
        public string ErrorMessage { get; private set; }

        public InvalidRangeException(int start, int end) 
            : this(start.ToString(), end.ToString())
        {
        }
        public InvalidRangeException(string start, string end)
        {
            this.Start = start;
            this.End = end;
        }

        public void CheckRange(T objectToCompare)
        {
            if (objectToCompare is DateTime)
            {
                try
                {
                    DateTime tempDateTime = DateTime.Parse(objectToCompare.ToString());
                    DateTime startDateTime = DateTime.Parse(this.Start);
                    DateTime endDateTime = DateTime.Parse(this.End);

                    if (tempDateTime < startDateTime || tempDateTime > endDateTime)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        this.ErrorMessage = "Everything in range!";
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    this.ErrorMessage = ex.Message;
                }
                catch (Exception ex)
                {
                    this.ErrorMessage = ex.Message;
                }
            }
            else if (objectToCompare is int)
            {

            }
            else if (objectToCompare is string)
            {

            }
        }
    }
}
