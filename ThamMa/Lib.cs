using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThamMa
{
    class Lib
    {
        public static string ReadTextFile_CSymm4(string sFilePath)
        {
            string result = "";
            try
            {
                StreamReader reader = new StreamReader(sFilePath, Encoding.UTF8);
                string line = reader.ReadLine();


                while (true)
                {
                    result = result + line;
                    line = reader.ReadLine();
                    if (line == null)
                        break;
                    result = result + "\n";
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
        public static bool WriteTextFile_CSymm4(string sFilePath, string sData)
        {
            bool bl = true;
            try
            {
                StreamWriter sw = new StreamWriter(sFilePath, false, Encoding.Unicode);
                sw.WriteLine(sData);
                sw.Close();
            }
            catch
            {
                bl = false;
            }
            return bl;
        }
        public static float[] tinhTanSo1(string BangChuCai, string Text)
        {
            float[] tanso= new float[96];
            float tong = 0;
            string tempt = Text;
            string[] chuCai = BangChuCai.Split(' ');

            Hashtable htChuCai = new Hashtable();
            for(int i = 0; i < chuCai.Length; i++)
            {
                htChuCai.Add(chuCai[i], 0);
            }

            for(int i = 0; i < Text.Length; i++)
            {
                try
                {
                    htChuCai[Text[i].ToString()] = Int32.Parse(htChuCai[Text[i].ToString()].ToString()) + 1;
                    tong++;
                }
                catch(Exception e)
                {

                }
            }
            for(int i = 0; i < chuCai.Length; i++)
            {
                tanso[i] = float.Parse(htChuCai[chuCai[i].ToString()].ToString()) / tong;
            }
            return tanso;
        }
        public static float[] tinhTanSo2(string BangChuCai, string Text)
        {
            float[] tanso = new float[96];
            float tong = 0;
            string tempt = Text;
            string[] chuCai = BangChuCai.Split(' ');

            Hashtable htChuCai = new Hashtable();
            for (int i = 0; i < chuCai.Length; i++)
            {
                htChuCai.Add(chuCai[i], 0);
            }

            for (int i = 0; i < Text.Length-1; i++)
            {
                try
                {
                    htChuCai[Text[i].ToString()+ Text[i+1].ToString()] = Int32.Parse(htChuCai[Text[i].ToString() + Text[i + 1].ToString()].ToString()) + 1;
                    tong++;
                }
                catch (Exception e)
                {

                }
            }
            
            for (int i = 0; i < chuCai.Length; i++)
            {
                tanso[i] = float.Parse(htChuCai[chuCai[i].ToString()].ToString()) / tong;
            }
            return tanso;
        }
    }
}
