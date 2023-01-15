using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMSmain.BL;
using DMSmain.Interfaces;

namespace DMSmain.DL
{
    internal class MUserDL
    {
        private static List<MUser> user = new List<MUser>();
        public static MUser currentUser;
        public static List<MUser> User { get => user; }    //read only attribute


        public static MUser Authenticate(MUser users)
        {
            foreach (MUser i in User)
            {
                if (i == users)
                {
                    currentUser = i;
                    return i;
                }
            }
            return null;
        }

        public static void addintoList(MUser m)
        {
            User.Add(m);
        }
        public static void writeInFile()
        {
            string path = "users.csv";
            StreamWriter file = new StreamWriter(path);
            foreach (MUser i in user)
            {
                file.WriteLine(i.Username + "," + i.Password + "," + i.Role);
                file.Flush();
            }
            file.Close();

        }
        public static void LoadFromFile()
        {
            User.Clear();
            string path = "users.csv";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string usernameA = record[0];
                    string passwordA = record[1];
                    string role = record[2];
                    MUser obj = new MUser(usernameA, passwordA, role);
                    addintoList(obj);
                }
                file.Close();
            }
        }
    }
}

