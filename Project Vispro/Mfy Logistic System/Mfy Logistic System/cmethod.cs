using System.IO;

namespace Mfy_Logistic_System
{
    internal class cmethod
    {
        public static string GetConnString()
        {
            FileStream fs = new FileStream("C:\\Users\\chris\\OneDrive\\Project Vispro\\projectmfyconnstring.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string connectionstring = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            return (connectionstring);
            
        }

        public static string selecteduser { get; set; }

        public static string selectedcstname { get; set; }

        public static string selectedkplname { get; set; }

        public static string selectedkplcompany { get; set; }

        public static string selectedkplid { get; set; }

        public static int checkupdatekpl { get; set; }

        public static int selectedvoyno { get; set; }

        public static int checksearchvoy { get; set; }

        public static string selectedvoyid { get; set; }

        public static string selectedorgcityvoy { get; set; }

        public static string selectedfnlcityvoy { get; set; }

        public static string selectedorgdatevoy { get; set; }

        public static string selectedfnldatevoy { get; set; }

        public static int checksearchship { get; set; }

        public static string selectedcontid { get; set; }


        public static string selectedcontcode { get; set; }


        public static string selectedcontno { get; set; }


        public static string selectedcontitem { get; set; }

        public static int checksearchcont { get; set; }

        public static string selectedsndid { get; set; }

        public static string selectedsndname { get; set; }


        public static string selectedrcvid { get; set; }

        public static string selectedrcvname { get; set; }
    }
}