using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class GameConverter
    {
        public static FindingCallNumbersLevels ConvertToGameModel(FindingCallNumbersGame deweyGame)
        {
            return new FindingCallNumbersLevels { Number = deweyGame.Number, Description = deweyGame.Description };
        }

        public static List<FindingCallNumbersLevels> ConvertListToGameModel(List<FindingCallNumbersGame> games)
        {
            List<FindingCallNumbersLevels> gmList = new List<FindingCallNumbersLevels>();

            games.ForEach(x => gmList.Add(ConvertToGameModel(x)));

            return gmList;
        }
    }
}
