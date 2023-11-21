using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class FindingCallNum
    {
        public TreeLevel GetLevel()
        {
            TreeLevel level = new TreeLevel();

            List<FindingCallNumbersGame> lstAnswerPath = GlobalTree.Tree.GetPathToRandom(GlobalTree.Tree.Root, 3);

            List<FindingCallNumbersGame> lstIncorrectChoice1 = new List<FindingCallNumbersGame>();
            List<FindingCallNumbersGame> lstIncorrectChoice2 = new List<FindingCallNumbersGame>();
            List<FindingCallNumbersGame> lstIncorrectChoice3 = new List<FindingCallNumbersGame>();

            while (lstIncorrectChoice1.Count < 3)
            {
                FindingCallNumbersGame r = GlobalTree.Tree.GetRandom(1);

                if (!lstAnswerPath.Contains(r) && !lstIncorrectChoice1.Contains(r))
                {
                    lstIncorrectChoice1.Add(r);
                }
            }

            lstIncorrectChoice2 = GlobalTree.Tree.GetChildren(lstAnswerPath[0]);

            if (lstIncorrectChoice2.Remove(lstAnswerPath[1]))
            {
                Console.WriteLine("Removed Answer");
            }

            while (lstIncorrectChoice2.Count > 3)
            {
                Random r = new Random();

                int index = r.Next(lstIncorrectChoice2.Count);

                lstIncorrectChoice2.RemoveAt(index);
            }

            while (lstIncorrectChoice2.Count < 3)
            {
                FindingCallNumbersGame r = GlobalTree.Tree.GetRandom(2);

                if (!lstAnswerPath.Contains(r) && !lstIncorrectChoice2.Contains(r))
                {
                    lstIncorrectChoice2.Add(r);
                }
            }

            List<FindingCallNumbersGame> children = GlobalTree.Tree.GetChildren(lstAnswerPath[1]);

            while (lstIncorrectChoice3.Count < 3)
            {
                Random r = new Random();

                int index = r.Next(children.Count);

                if (!lstAnswerPath.Contains(children[index]) && !lstIncorrectChoice3.Contains(children[index]))
                {
                    lstIncorrectChoice3.Add(children[index]);
                }
            }

            List<FindingCallNumbersLevels> lvl1 = new List<FindingCallNumbersLevels>();
            List<FindingCallNumbersLevels> lvl2 = new List<FindingCallNumbersLevels>();
            List<FindingCallNumbersLevels> lvl3 = new List<FindingCallNumbersLevels>();
            List<FindingCallNumbersLevels> correctAns = new List<FindingCallNumbersLevels>();

            correctAns = GameConverter.ConvertListToGameModel(lstAnswerPath);
            correctAns.ForEach(x => x.Correct = true);

            lvl1 = GameConverter.ConvertListToGameModel(lstIncorrectChoice1);
            lvl1.ForEach(x => x.Correct = false);
            lvl2 = GameConverter.ConvertListToGameModel(lstIncorrectChoice2);
            lvl2.ForEach(x => x.Correct = false);
            lvl3 = GameConverter.ConvertListToGameModel(lstIncorrectChoice3);
            lvl3.ForEach(x => x.Correct = false);

            lvl1.Add(correctAns[0]);
            lvl2.Add(correctAns[1]);
            lvl3.Add(correctAns[2]);

            lvl1 = lvl1.OrderBy(x => x.Number).ToList();
            lvl2 = lvl2.OrderBy(x => x.Number).ToList();
            lvl3 = lvl3.OrderBy(x => x.Number).ToList();

            level.AnswerPath = correctAns;
            level.Level1Options = lvl1;
            level.Level2Options = lvl2;
            level.Level3Options = lvl3;

            return level;
        }
    }
}
