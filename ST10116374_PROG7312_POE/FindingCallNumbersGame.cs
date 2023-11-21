using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class FindingCallNumbersGame : IComparable<FindingCallNumbersGame>
    {
        public string Number { get; set; }
        public string Description { get; set; }

        public FindingCallNumbersGame()
        {

        }

        public int CompareTo(FindingCallNumbersGame other)
        {
            return this.Number.CompareTo(other.Number);
        }
    }
}
