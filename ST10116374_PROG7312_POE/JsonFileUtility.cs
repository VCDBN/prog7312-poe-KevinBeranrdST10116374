using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class JsonFileUtility
    {
        public static string TreeGameDataFile = "FindingCallNumbersTreeData.json";

        //This method checks if the data file exist
        public static bool TreeGameDataExists()
        {
            if (File.Exists(TreeGameDataFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Makes the file if it does not exists
        public static void CreateTreeDataFile()
        {
            
            Tree<FindingCallNumbersGame> tree = CreateTree.GrowATree();

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            string treeJSON = JsonSerializer.Serialize(tree, options);

            using (StreamWriter sw = File.CreateText(TreeGameDataFile))
            {
                sw.WriteLine(treeJSON);
            }
        }

        public static Tree<FindingCallNumbersGame> GetTree()
        {
            return JsonSerializer.Deserialize<Tree<FindingCallNumbersGame>>(File.ReadAllText(TreeGameDataFile));
        }
    }
}
