using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class TreeLevel
    {
        public List<FindingCallNumbersLevels> AnswerPath { get; set; }
        public List<FindingCallNumbersLevels> Level1Options { get; set; }
        public List<FindingCallNumbersLevels> Level2Options { get; set; }
        public List<FindingCallNumbersLevels> Level3Options { get; set; }
    }
}
