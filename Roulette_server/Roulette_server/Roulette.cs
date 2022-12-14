using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Roulette_server
{
    public class Roulette
    {
        public List<Number> number { get; set; }
        public int[] quote;
        public Roulette()
        {
            number = new List<Number>();
            number.AddRange(new List<Number>
            {
                new Number(0,"green"),
                new Number(32,"red"),
                new Number(15,"black"),
                new Number(19,"red"),
                new Number(4,"black"),
                new Number(21,"red"),
                new Number(2,"black"),
                new Number(25,"red"),
                new Number(17,"black"),
                new Number(34,"red"),
                new Number(6,"black"),
                new Number(27,"red"),
                new Number(13,"black"),
                new Number(36,"red"),
                new Number(11,"black"),
                new Number(30,"red"),
                new Number(8,"black"),
                new Number(23,"red"),
                new Number(10,"black"),
                new Number(5,"red"),
                new Number(24,"black"),
                new Number(16,"red"),
                new Number(33,"black"),
                new Number(1,"red"),
                new Number(20,"black"),
                new Number(14,"red"),
                new Number(31,"black"),
                new Number(9,"red"),
                new Number(22,"black"),
                new Number(18,"red"),
                new Number(29,"black"),
                new Number(7,"red"),
                new Number(28,"black"),
                new Number(12,"red"),
                new Number(35,"black"),
                new Number(3,"red"),
                new Number(26,"black"),
            });
        }
        public int Vincita(List<string> n_estratto, List<string> n_giocatore, List<int> soldi)
        {
            int v = 0;
            int i = 0;
            int q = 0;
            List<int> Temp = new List<int>();
            foreach (string g in n_giocatore)
            {
                q = 0;
                foreach (string n in n_estratto)
                {
                    if (g == n)
                    {
                        v += soldi[i] * quota(q);
                    }
                    q++;
                }
                i++;
            }
            return v;
        }
        private int quota(int i)
        {
            int q = 0;
            switch (i)
            {
                case 0:
                    q = 36;
                    break;
                case 1:
                    q = 2;
                    break;
                case 2:
                    q = 3;
                    break;
                case 3:
                    q = 2;
                    break;
                case 4:
                    q = 2;
                    break;
                case 5:
                    q = 3;
                    break;
            }
            return q;
        }
    }
}