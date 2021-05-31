using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_12
{
    class Management
    {
        Random rand = new Random();
        public int[] winner = new int[8];
        public int[] winner_2 = new int[8];
        public int[] win = new int[4];
        public int winn = -1;

        public int Head(int l)
        {

            int m = 0;
            double S = 0;
            while (S >= -l)
            {
                double a = rand.NextDouble();
                S += Math.Log(a);
                m++;
            }
            return m;
        }
        int kom_1 = 0;
        int kom_2 = 0;

        public string Match(int a, int b, string[] kom_name, int[] kom_ln)
        {
            winn++;
            string match = "";
            match += "Сейчас " + kom_name[a] + " VS " + kom_name[b] + "." + Environment.NewLine;
            kom_1 = Head(kom_ln[a]);
            kom_2 = Head(kom_ln[b]);
            match += "Команда " + kom_name[a] + " набрала " + kom_1 + " голов." + Environment.NewLine;
            match += "Команда " + kom_name[b] + " набрала " + kom_2 + " голов." + Environment.NewLine;
            if (kom_1 > kom_2)
            {
                match += "Победу одержала " + kom_name[a] + " !" + Environment.NewLine;
                winner[a] = 1;
                win[winn] = a;
            }
            else if (kom_1 < kom_2)
            {
                match += "Победу одержала " + kom_name[b] + " !" + Environment.NewLine;
                winner[b] = 1;
                win[winn] = b;

            }
            else
            {
                match += Fifty(a, b, kom_name, winn);
            }


            match += " " + Environment.NewLine;
            if (winn == 3) winn = -1;
            return match;
        }


        public string Fifty(int a, int b, string[] kom_name, int winn)
        {
            string fifty = "";
            fifty += "Ничья! Назнанины дополнительное время." + Environment.NewLine;
            kom_1 = Head(2);
            kom_2 = Head(2);
            if (kom_1 > kom_2)
            {
                fifty += "Набрав дополнительные " + kom_1 + " голов, когда " + kom_name[b] + " набрала " + kom_2 + " голов. Выигрывает: " + kom_name[a] + Environment.NewLine;
                win[winn] = a;
            }
            else if (kom_2 > kom_1)
            {
                fifty += "Набрав дополнительные " + kom_2 + " голов, когда " + kom_name[a] + " набрала " + kom_1 + " голов. Выигрывает: " + kom_name[b] + Environment.NewLine;
                win[winn] = b;


            }
            else
            {
                fifty += Last(a, b, kom_name, kom_1, winn);
            }
            return fifty;
        }

        public string Last(int a, int b, string[] kom_name, int k, int winn)
        {
            kom_1 = 0;
            kom_2 = 0;
            string last = "Из-за равного числа (" + k + ") голов во время дополнительного времени, назначается послематчивае пенальти." + Environment.NewLine;
            if (Randd() == 0)
            {
                last += "Подбрасыванием монетки начнут бить игроки " + kom_name[a] + Environment.NewLine;
                kom_1 += Randd();
            }
            else
            {
                last += "Подбрасыванием монетки начнут бить игроки " + kom_name[b] + Environment.NewLine;
                kom_2 += Randd();
            }
            while ((kom_1 < 6) | (kom_2 < 6))
            {
                kom_1 += Randd();
                kom_2 += Randd();
            }
            if (kom_1 > kom_2)
            {
                last += "Победу одерживает " + kom_name[a] + Environment.NewLine;
                win[winn] = a;

            }
            else
            {
                last += "Победу одерживает " + kom_name[b] + Environment.NewLine;
                win[winn] = b;

            }
            return last;
        }
        public int Randd()
        {
            int k = 5;
            double a = 0;
            double p = 0.5;
            a = rand.NextDouble();
            if (a < p)
            {
                k = 0;
            }
            else
            {
                k = 1;

            }
            return k;
        }
    }
}
