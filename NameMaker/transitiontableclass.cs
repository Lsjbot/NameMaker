using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMaker
{
    class transitiontableclass
    {
        public static char startchar = '#';
        public static char endchar = '#';
        private Dictionary<char, Dictionary<char, double>> table = new Dictionary<char, Dictionary<char, double>>();
        private Dictionary<string, Dictionary<char, double>> table2 = new Dictionary<string, Dictionary<char, double>>();

        private Random rnd = new Random();

        public void addpair(char c1, char c2)
        {
            addpair(c1, c2, 1);
        }
        public void addpair(char c1,char c2,double w)
        {
            if (!table.ContainsKey(c1))
                table.Add(c1, new Dictionary<char, double>());
            if (!table[c1].ContainsKey(c2))
            {
                table[c1].Add(c2, w);
            }
            else
            {
                table[c1][c2] += w;
            }
        }

        public void addpair(string c1, char c2)
        {
            addpair(c1, c2, 1);
        }
        public void addpair(string c1, char c2, double w)
        {
            if (!table2.ContainsKey(c1))
                table2.Add(c1, new Dictionary<char, double>());
            if (!table2[c1].ContainsKey(c2))
            {
                table2[c1].Add(c2, w);
            }
            else
            {
                table2[c1][c2] += w;
            }
        }

        public void normalize()
        {
            foreach (char c1 in table.Keys)
                normalize_row(c1);
            foreach (string c1 in table2.Keys)
                normalize_row(c1);
        }

        public void normalize_row(char c1)
        {
            double total = table[c1].Values.Sum();
            if (total <= 0)
                return;

            foreach (char c2 in table[c1].Keys.ToList())
            {
                table[c1][c2] /= total;
            }
        }

        public void normalize_row(string c1)
        {
            double total = table2[c1].Values.Sum();
            if (total <= 0)
                return;

            foreach (char c2 in table2[c1].Keys.ToList())
            {
                table2[c1][c2] /= total;
            }
        }

        public char get_next(char c1)
        {
            //char cnext = endchar;
            double r = rnd.NextDouble();
            double sum = 0;
            foreach (char c2 in table[c1].Keys)
            {
                sum += table[c1][c2];
                if (r < sum)
                    return c2;
            }
            return endchar;
        }

        public char get_next(string c1)
        {
            //char cnext = endchar;
            double r = rnd.NextDouble();
            double sum = 0;
            foreach (char c2 in table2[c1].Keys)
            {
                sum += table2[c1][c2];
                if (r < sum)
                    return c2;
            }
            return endchar;
        }
    }
}
