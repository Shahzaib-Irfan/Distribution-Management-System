using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DMSmain.BL;

namespace DMSmain.DL
{
    internal class RiderDL
    {
        public static List<Rider> riders = new List<Rider>();

        public static void AddRiderIntoList(Rider r)
        {
            riders.Add(r);
        }
        public static Rider getRiderByCNIC(Rider r)
        {
            foreach(Rider rider in riders)
            {
                if (r.getCNIC() == rider.getCNIC()) return rider;
            }
            return null;
        }
        public static Rider getRiderBYUsername(MUser user)
        {
            riders.Clear();
            LoadFromFile();
            foreach(var i in riders)
            {
                if(i.Username == user.Username && i.Password == user.Password)
                {
                    return i;
                }
            }
            return null;
        }

        public static List<Rider> deleteRider(Rider rider)
        {
            for (int i = 0; i < riders.Count; i++)
            {
                if (riders[i] == rider)
                {
                    riders.RemoveAt(i);
                }
            }
            return riders;
        }

        public static List<Rider> updateRider(Rider riderOriginal, Rider updated)
        {
            for (int i = 0; i < riders.Count; i++)
            {
                if (riders[i] == riderOriginal)
                {
                    riders[i] = updated;
                }
            }
            return riders;
        }

        public static void writeInFile()
        {
            string path = "riders.csv";
            StreamWriter file = new StreamWriter(path, false);
            foreach (Rider i in riders)
            {
                file.WriteLine(i.getName() + "," + i.getCNIC() + "," + i.getPhoneNo() + "," + i.getEmail() + "," + i.Area + "," + i.Username + "," + i.Password + "," + i.Role);
            }
            file.WriteLine();
            file.Flush();
            file.Close();

        }
        public static void LoadFromFile()
        {
            riders.Clear();
            string path = "riders.csv";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != "" || (item = file.ReadLine()) != null || item != null)
                {
                    if (item == null) break;

                    string[] record = item.Split(',');
                    string name = record[0];
                    string cnic = record[1];
                    string phoneNo = record[2];
                    string email = record[3];
                    string area = record[4];
                    string username = record[5];
                    string password = record[6];
                    string role = record[7];
                    Rider rider = new Rider(name, cnic, phoneNo, email,area, username, password, role);
                    AddRiderIntoList(rider);
                    //try
                    //{
                    //    string[] record = item.Split(',');
                    //    string name = record[0];
                    //    string cnic = record[1];
                    //    string phoneNo = record[2];
                    //    string email = record[3];
                    //    string username = record[4];
                    //    string password = record[5];
                    //    string role = record[6];
                    //    Rider rider = new Rider(name, cnic, phoneNo, email, username, password,role);
                    //    AddRiderIntoList(rider);
                    //}
                    //catch (Exception ex) { }
                }
                file.Close();
            }
        }
    }
}
