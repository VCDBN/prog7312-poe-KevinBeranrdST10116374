using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class CreateTree
    {
        public static Tree<FindingCallNumbersGame> GrowATree()
        {
            FindingCallNumbersGame basePair = new FindingCallNumbersGame { Number = "---", Description = "ROOT" };
            Tree<FindingCallNumbersGame> lstPair = new Tree<FindingCallNumbersGame>(basePair);

           
            List<FindingCallNumbersGame> lstLevel1 = new List<FindingCallNumbersGame>();

            lstLevel1.Add(new FindingCallNumbersGame { Number = "000", Description = "Computer science, information, and general works" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "100", Description = "Philosophy and Psychology" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "200", Description = "Religion" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "300", Description = "Social Sciences" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "400", Description = "Language" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "500", Description = "Science" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "600", Description = "Applied Sciences" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "700", Description = "The Arts" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "800", Description = "Literature" });
            lstLevel1.Add(new FindingCallNumbersGame { Number = "900", Description = "History and geography" });

            lstPair.AddChildren(lstLevel1, basePair);
            
            List<FindingCallNumbersGame> l000 = ComputerScience();
            List<FindingCallNumbersGame> l100 = Philosophy();
            List<FindingCallNumbersGame> l200 = Religion();
            List<FindingCallNumbersGame> l300 = SocialScience();
            List<FindingCallNumbersGame> l400 = Language();
            List<FindingCallNumbersGame> l500 = Science();
            List<FindingCallNumbersGame> l600 = Technology();
            List<FindingCallNumbersGame> l700 = Arts();
            List<FindingCallNumbersGame> l800 = Literature();
            List<FindingCallNumbersGame> l900 = History();

            lstPair.AddChildren(l000, lstLevel1[0]);
            lstPair.AddChildren(l100, lstLevel1[1]);
            lstPair.AddChildren(l200, lstLevel1[2]);
            lstPair.AddChildren(l300, lstLevel1[3]);
            lstPair.AddChildren(l400, lstLevel1[4]);
            lstPair.AddChildren(l500, lstLevel1[5]);
            lstPair.AddChildren(l600, lstLevel1[6]);
            lstPair.AddChildren(l700, lstLevel1[7]);
            lstPair.AddChildren(l800, lstLevel1[8]);
            lstPair.AddChildren(l900, lstLevel1[9]);

            lstPair.AddChildren(ComputerscienceCall(), l000[0]);
            lstPair.AddChildren(Bibliographies(), l000[1]);
            lstPair.AddChildren(Library(), l000[2]);
            lstPair.AddChildren(Encyclopedias(), l000[3]);
            
            
            lstPair.AddChildren(Metaphysics(), l100[0]);
            lstPair.AddChildren(Parapsychology(), l100[1]);
            lstPair.AddChildren(Philosophicallogics(), l100[2]);
            lstPair.AddChildren(Ethics(), l100[3]);

            lstPair.AddChildren(PhilosophyofReligion(), l200[0]);
            lstPair.AddChildren(Bible(), l200[1]);
            lstPair.AddChildren(Christianity(), l200[2]);
            lstPair.AddChildren(localchurch(), l200[3]);

            lstPair.AddChildren(Economics(), l300[0]);
            lstPair.AddChildren(Law(), l300[1]);
            lstPair.AddChildren(Education(), l300[2]);
            lstPair.AddChildren(Customs(), l300[3]);

            lstPair.AddChildren(Linguistics(), l400[0]);
            lstPair.AddChildren(English(), l400[1]);
            lstPair.AddChildren(German(), l400[2]);
            lstPair.AddChildren(French(), l400[3]);

            lstPair.AddChildren(Mathematics(), l500[0]);
            lstPair.AddChildren(Physics(), l500[1]);
            lstPair.AddChildren(Biology(), l500[2]);
            lstPair.AddChildren(Plants(), l500[3]);

            lstPair.AddChildren(Medicine(), l600[0]);
            lstPair.AddChildren(Engineering(), l600[1]);
            lstPair.AddChildren(Agriculture(), l600[2]);
            lstPair.AddChildren(Management(), l600[3]);

            lstPair.AddChildren(CivicLandscapes(), l700[0]);
            lstPair.AddChildren(Architecture(), l700[1]);
            lstPair.AddChildren(Sculpture(), l700[2]);
            lstPair.AddChildren(Painting(), l700[3]);

            lstPair.AddChildren(AmericanLiterature(), l800[0]);
            lstPair.AddChildren(GermanLiterature(), l800[1]);
            lstPair.AddChildren(FrenchLiterature(), l800[2]);
            lstPair.AddChildren(OtherLiterature(), l800[3]);

            lstPair.AddChildren(Historyancient(), l900[0]);
            lstPair.AddChildren(HistoryEurope(), l900[1]);
            lstPair.AddChildren(HistoryAsia(), l900[2]);
            lstPair.AddChildren(HistoryAfrica(), l900[3]);

            lstPair.OrderTraversal(lstPair.Root);

            return lstPair;
        }

        public static List<FindingCallNumbersGame> ComputerScience()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "000", Description = "Computer science" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "010", Description = "Bibliographies" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "020", Description = "Library and information sciences" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "030", Description = "General encyclopedic works" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "050", Description = "Magazines" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "060", Description = "Associations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "070", Description = "News media" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "080", Description = "Quotations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "090", Description = "Manuscripts" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> ComputerscienceCall()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "000", Description = "Computer science" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "001", Description = "Knowledge" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "002", Description = "The book" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "003", Description = "Systems" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "004", Description = "Data processing" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "005", Description = "Programming" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "006", Description = "Special computer methods" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Bibliographies()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "010", Description = "Bibliography" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "011", Description = "Bibliographies" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "012", Description = "Bibliographies of individuals" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "014", Description = "Bibliographies of anonymous" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "015", Description = "Bibliographies of works from specific places" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "016", Description = "Bibliographies of works on specific subjects" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "017", Description = "General subject catalogs " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "018", Description = "Catalogs arranged by author" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "019", Description = "Dictionary catalogs" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Library()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "020", Description = "Library and information sciences" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "021", Description = "Library relationships" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "022", Description = "Administration of physical plant" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "023", Description = "Personnel management" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "025", Description = "Library operations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "026", Description = "Libraries for specific subjects" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "027", Description = "General libraries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "028", Description = "Reading and use of other information media" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Encyclopedias()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "030", Description = "General encyclopedic works" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "031", Description = "Encyclopedias in American English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "032", Description = "Encyclopedias in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "033", Description = "Encyclopedias in other Germanic languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "034", Description = "Encyclopedias in French, Occitan, and Catalan" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "035", Description = "Encyclopedias in Italian, Romanian, and related languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "036", Description = "Encyclopedias in Spanish and Portuguese" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "037", Description = "Encyclopedias in Slavic languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "038", Description = "Encyclopedias in Scandinavian languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "039", Description = "Encyclopedias in other languages" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Philosophy()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "110", Description = "Metaphysics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "130", Description = "Parapsychology and occultism" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "160", Description = "Philosophical logics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "170", Description = "Ethics" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Metaphysics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "110", Description = "Ontology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "111", Description = "Ontology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "113", Description = "Cosmology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "114", Description = "Space" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "115", Description = "Time" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "116", Description = "Change" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "117", Description = "Structure" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "118", Description = "Force and energy" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "119", Description = "Number and quantity" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Parapsychology()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "130", Description = "Parapsychology and occultism" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "131", Description = "Parapsychological and occult methods for achieving well-being" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "133", Description = "pecific topics in parapsychology and occultism" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "135", Description = "Dreams and Mysteries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "137", Description = "Divinatory graphologies" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "138", Description = "Physiognomy" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "139", Description = "Phrenology" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Philosophicallogics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "160", Description = "160 Philosophical logics " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "161", Description = "Induction" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "162", Description = "Deduction" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "165", Description = "Fallacies and sources of error" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "166", Description = "Syllogisms" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "167", Description = "Hypotheses" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "167", Description = "Argument and persuasion" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "169", Description = "Analogy" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Ethics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "170", Description = "170 Ethics (Moral philosophy) " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "171", Description = "Ethical systems" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "172", Description = "Political Ethics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "173", Description = "Ethics of Family Relationships" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "174", Description = "Occupational ethics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "175", Description = "Ethics of recreation, leisure, public performances, communication " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "176", Description = "Ethics of sex and reproduction" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "177", Description = "Ethics of social relations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "178", Description = "Ethics of consumption " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "179", Description = "Other ethical norms" });

            return lstPairs;

        }

        public static List<FindingCallNumbersGame> Religion()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "210", Description = "Philosophy and theory of religion" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "220", Description = "The Bible" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "230", Description = "Christianity" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "250", Description = "Christian orders and local church" });
            return lstPairs;
        }

        public static List<FindingCallNumbersGame> PhilosophyofReligion()
        {

            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "210", Description = "Philosophy and theory of religion" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "211", Description = "Concepts of God" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "212", Description = "Existence, Attributes of God" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "213", Description = "Creation" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "214", Description = "Theodicy" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "215", Description = "Science and religion" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "218", Description = "Humankind" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Bible()
        {

            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "220", Description = "Bible" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "221", Description = "Old Testament" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "222", Description = "Historical books of Old Testament" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "223", Description = "Poetic books of Old Testament" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "224", Description = "Prophetic books of Old Testament" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "225", Description = "New Testament" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "226", Description = "Gospels and Acts" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "227", Description = "Epistles" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "228", Description = "Revelation " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "228", Description = "Apocrypha, pseudepigrapha, and inter-test amental works" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Christianity()
        {

            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "230", Description = "Christianity" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "231", Description = "God" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "232", Description = "Jesus Christ and his family" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "233", Description = "Humankind" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "234", Description = "Salvation and grace" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "235", Description = "Spiritual beings" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "236", Description = "Eschatology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "238", Description = "Creeds, confessions of faith, covenants, and catechisms" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "239", Description = "Apologetics and polemics" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> localchurch()
        {

            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "250", Description = " Local Christian church and Christian religious orders " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "251", Description = "Preaching (Homiletics)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "252", Description = "Texts of sermons" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "253", Description = "Pastoral office and work (Pastoral theology)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "254", Description = "Parish administration" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "255", Description = "Religious congregations and orders" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "259", Description = "Pastoral care of families of specific groups of people" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> SocialScience()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "330", Description = "Economics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "340", Description = "Law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "370", Description = "Education" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "390", Description = "Customs, etiquette and folklore" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Economics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "330", Description = "Economics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "331", Description = "Labor Economics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "332", Description = "Financial Economics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "333", Description = "Economics of land and energy" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "334", Description = "Cooperatives" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "335", Description = "Socialism and related systems " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "336", Description = "Public finance" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "337", Description = "International economics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "338", Description = "Production" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "339", Description = "Macroeconomics and related topics" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Law()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "340", Description = "Law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "341", Description = "Law of nations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "342", Description = "Constitutional and Administrative Law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "343", Description = "Military, defense, public property Law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "344", Description = "Cultural law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "345", Description = "Criminal law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "346", Description = "Private Law" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "347", Description = "Procedure and courts" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "348", Description = "Laws, regulations, cases" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "349", Description = "Law of specific jurisdictions" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Education()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "370", Description = "Education" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "371", Description = "Schools and their activities, special education" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "372", Description = "Primary education" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "373", Description = "Secondary education" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "374", Description = "Adult education" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "375", Description = "Curriculum" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "378", Description = "Higher educations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "379", Description = "Public policy issues in education" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Customs()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "390", Description = "Customs, etiquette, folklore" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "391", Description = "Costume and personal appearance" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "392", Description = "Customs of life cycle and domestic life" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "393", Description = "Death customs" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "394", Description = "General customs" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "395", Description = "Etiquette (Manners)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "398", Description = "Customs of war and diplomacy" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Language()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "410", Description = "Linguistics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "420", Description = "English and Old English languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "430", Description = "German and related languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "440", Description = "French and related languages" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Linguistics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "410", Description = "Linguistics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "411", Description = "Writing systems of standard forms of languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "412", Description = "Etymology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "413", Description = "Dictionaries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "414", Description = "Phonology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "415", Description = "Grammar " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "417", Description = "Dialectology " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "418", Description = "Standard usage" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "419", Description = "Sign languages" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> English()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "420", Description = "English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "421", Description = "phonetics of standard English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "422", Description = "Etymology of standard English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "423", Description = "Dictionaries of standard English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "425", Description = "Grammar of standard English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "427", Description = "modern nongeographic variations of English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "428", Description = "Standard English usage" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "429", Description = "Old English" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> German()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "430", Description = "German" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "431", Description = "phonetics of standard German" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "432", Description = "Etymology of standard German" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "433", Description = "Dictionaries of standard German" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "435", Description = "Grammar of standard German" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "437", Description = "modern nongeographic variations of German" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "438", Description = "Standard German usage" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "439", Description = "Other Germanic languages" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> French()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "440", Description = "French and related Romance languages " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "441", Description = "phonetics of standard French  " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "442", Description = "Etymology of standard French " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "443", Description = "Dictionaries of standard French " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "445", Description = "Grammar of standard French " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "447", Description = "modern nongeographic variations of French  " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "448", Description = "Standard French  usage" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "449", Description = "Occitan Catalan, Franco-Provençal" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Science()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "510", Description = "Mathematics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "530", Description = "Physics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "570", Description = "Biology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "580", Description = "Plants" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Mathematics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "511", Description = "Mathematics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "511", Description = "General Principles" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "512", Description = "Algebra" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "513", Description = "Arithmetic" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "514", Description = "Topology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "515", Description = "Analysis" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "516", Description = "Geometry" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "518", Description = "Numerical analysis" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "519", Description = "Probabilities and applied mathematics " });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Physics()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "530", Description = "Physics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "531", Description = "Classical mechanics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "532", Description = "Fluid Mechanics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "533", Description = "Pneumatics (Gas mechanics)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "534", Description = "Sound and related vibrations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "535", Description = "Light and related radiation" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "536", Description = "Heat" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "537", Description = "Electricty and Electronics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "538", Description = "Magnetism" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "539", Description = "Modern physics" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Biology()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "570", Description = "Biology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "571", Description = "Physiology and related subjects" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "572", Description = "Biochemistry" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "573", Description = "Specific physiological systems in animals" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "575", Description = "Specific parts of and physiological systems in plants" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "576", Description = "Genetics and evolution" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "577", Description = "Ecology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "578", Description = "Natural history of organisms and related subjects" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "579", Description = "Natural history of microorganisms, fungi, algae" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Plants()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "580", Description = "Plants" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "581", Description = "Specific topics in natural history of plants " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "582", Description = "Plants noted for specific vegetative characteristics and flowers" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "583", Description = "Magnoliopsida " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "584", Description = "Liliopsida " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "585", Description = "Pinophyta" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "586", Description = "Cryptogamia" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "587", Description = "Pteridophyta" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "588", Description = "Bryophyta" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Technology()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "610", Description = "Medicine and health" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "620", Description = "Engineering and Allied Operations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "630", Description = "Agriculture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "650", Description = "Management and public relations " });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Medicine()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "610", Description = "Medicine and health" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "611", Description = "Human anatomy, cytology, histology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "612", Description = "Human Physiology" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "613", Description = "Personal health and safety" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "614", Description = "Forensic medicines" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "615", Description = "Pharmacology and therapeutics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "616", Description = "Disesases" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "617", Description = "Surgery" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "618", Description = "Gynecology" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Engineering()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "620", Description = "Engineering and applied operations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "621", Description = "Applied Physics" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "622", Description = "Mining and Related Operations" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "623", Description = "Military and nautical engineering" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "624", Description = "Civil Engineering" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "625", Description = "Engineering of railroads, roads" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "627", Description = "Hydraulic Engineering" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "628", Description = "Sanitary engineering" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "629", Description = "Other branches of engineering" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Agriculture()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "630", Description = "Agriculture and related technologies" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "631", Description = "Specific techniques; apparatus, equipment, materials " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "632", Description = "Plant Injuries, Diseases, Pests" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "633", Description = "Field and Plantation crops" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "634", Description = "Orchards, fruits, forestry " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "635", Description = "Garden crops" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "636", Description = "Animal Husbandry" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "637", Description = "Processing dairy and related products" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "638", Description = "Insect culture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "639", Description = "Hunting, fishing, conservation, related technologies" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Management()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "650", Description = "Management and auxiliary services" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "651", Description = "Office services" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "652", Description = "Processes of written communication" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "653", Description = "Shorthand" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "657", Description = "Accounting" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "658", Description = "General management" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "659", Description = "Advertising and public relations" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Arts()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "710", Description = "Area planning and landscape architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "720", Description = "Architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "730", Description = "Sculpture, ceramics and metalwork " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "750", Description = "Painting" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> CivicLandscapes()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "710", Description = "Area planning and landscape architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "711", Description = "Area Planning (Civic Art)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "712", Description = "Landscape Architecture (Landscape design)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "713", Description = "Landscape architecture of trafficways" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "714", Description = "Water Features in landscape architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "715", Description = "Woody plants in landscape architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "716", Description = "Herbaceous plants in landscape architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "717", Description = "Structures in landscape architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "718", Description = "Landscape design of cemeteries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "719", Description = "Natural landscapes" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Architecture()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "720", Description = "Architecture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "721", Description = "Architectural materials and structural elements" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "722", Description = "Architecture from earliest times to c. 300" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "723", Description = "Architecture from c. 300 to 1399" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "724", Description = "Architecture from 1400" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "725", Description = "Public Structures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "726", Description = "Buildings for religious and related purposes" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "727", Description = "Buildings for educational and research purposes" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "728", Description = "Residential and related buildings " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "729", Description = "Design and decoration of structures and accessories" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Sculpture()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "730", Description = "Sculpture and related arts " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "731", Description = "Processes, forms, subjects of sculpture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "732", Description = "Sculpture to c. 500" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "733", Description = "Greek, Etruscan, Roman sculpture" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "734", Description = "Sculpture from ca 500 to 1399" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "735", Description = "Sculpture from 1400" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "736", Description = "Carving and carvings" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "737", Description = "Numismatics and sigillography" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "738", Description = "Ceramic Arts" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "739", Description = "Art Metalwork" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Painting()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "750", Description = "Painting and paintings" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "751", Description = "Techniques, procedures, apparatus, equipment, materials, forms" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "752", Description = "Color" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "753", Description = "Symbolism, allegory, mythology, legend " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "754", Description = "Genre Paintings" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "755", Description = "Religion" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "757", Description = "Human Figures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "758", Description = "Nature, architectural subjects and cityscapes, other specific subjects " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "759", Description = "History, geographic treatment, biography" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Literature()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "810", Description = "American Literature in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "830", Description = "German and related literatures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "840", Description = "French and related literatures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "890", Description = "Other literatures " });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> AmericanLiterature()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "810", Description = "American literature in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "811", Description = "American poetry in English " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "812", Description = "American drama in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "813", Description = "American fiction in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "814", Description = "American essays in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "815", Description = "American speeches in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "816", Description = "American letters in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "817", Description = "American humor and satire in English" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "818", Description = "American miscellaneous writings in English" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> GermanLiterature()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "830", Description = "German literature and literatures of related languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "831", Description = "German poetry" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "832", Description = "German drama" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "833", Description = "German fiction" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "834", Description = "German essays" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "835", Description = "German speeches" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "836", Description = "German letters" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "837", Description = "German humor and satire" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "838", Description = "German miscellaneous writings" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "839", Description = "Other Germanic literatures" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> FrenchLiterature()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "840", Description = "French literature and literatures of related Romance languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "841", Description = "French poetry" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "842", Description = "French drama" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "843", Description = "French fiction" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "844", Description = "French essays" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "845", Description = "French speeches" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "846", Description = "French letters" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "847", Description = "French humor and satire" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "848", Description = "French miscellaneous writings" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "849", Description = "Occitan, Catalan, Franco-Provençal literatures" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> OtherLiterature()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "890", Description = "Literatures of other specific languages and language families" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "891", Description = "East Indo-European and Celtic literatures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "892", Description = "Afro-Asiatic literatures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "893", Description = "Non-Semitic Afro-Asiatic literatures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "894", Description = "Literatures of Altaic" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "895", Description = "Literatures of East and Southeast Asia" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "896", Description = "African literatures" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "897", Description = "Literatures of North American native languages" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "898", Description = "Literatures of South American native languages " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "899", Description = "Literatures of non-Austronesian languages of Oceania" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> History()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "930", Description = "History of ancient world " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "940", Description = "History of Europe" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "950", Description = "History of Asia" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "960", Description = "History of Africa" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> Historyancient()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "990", Description = "History of ancient world" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "991", Description = "China to 420" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "992", Description = "Egypt to 640" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "993", Description = "Palestine to 70" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "994", Description = "South Asia to 647" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "995", Description = "Mesopotamia and Iranian Plateau to 637 " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "996", Description = "Europe north and west of Italian Peninsula to c. 499" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "997", Description = "Italy and adjacent territories to 476" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "998", Description = "Greece to 323" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "999", Description = "Other parts of ancient world" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> HistoryEurope()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "990", Description = "History of Europe" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "991", Description = "British Isles" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "992", Description = "England and Wales" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "993", Description = "Germany and neighboring central European countries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "994", Description = "France and Monaco" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "995", Description = "Italy, San Marino, Vatican City, Malta" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "996", Description = "Spain, Andorra, Gibraltar, Portugal" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "997", Description = "Russia and neighboring east European countries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "998", Description = "Scandinavia" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "999", Description = "Other parts of Europe" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> HistoryAsia()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "990", Description = "History of Asia" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "991", Description = "China and adjacent areas" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "992", Description = "Japan" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "993", Description = "Arabian Peninsula and adjacent areas" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "994", Description = "India and neighboring south Asian countries" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "995", Description = "Iran" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "996", Description = "Middle East (Near East)" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "997", Description = "Siberia (Asiatic Russia) " });
            lstPairs.Add(new FindingCallNumbersGame { Number = "998", Description = "Central Asia" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "999", Description = "Southeast Asia" });

            return lstPairs;
        }

        public static List<FindingCallNumbersGame> HistoryAfrica()
        {
            List<FindingCallNumbersGame> lstPairs = new List<FindingCallNumbersGame>();

            lstPairs.Add(new FindingCallNumbersGame { Number = "990", Description = "History of Africa" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "991", Description = "Tunisia and Libya" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "992", Description = "Egypt, Sudan, South Sudan" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "993", Description = "Ethiopia and Eritrea" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "994", Description = "Morocco, Ceuta, Melilla Western Sahara, Canary Islands" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "995", Description = "Algeria" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "996", Description = "West Africa and offshore islands" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "997", Description = "Central Africa and offshore islands" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "998", Description = "South Africa & southern Africa" });
            lstPairs.Add(new FindingCallNumbersGame { Number = "999", Description = "South Indian Ocean islands" });

            return lstPairs;
        }

    }
}
