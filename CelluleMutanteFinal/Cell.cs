using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CelluleMutanteFinal
{
    public class Cell
    {
        public int size;
        public Color color;
        string genetic;
        public int compteurBleu = 0;
        public int compteurViolet = 0;
        public int compteurOrange = 0;
        public int compteurBLack = 0;
        public int compteurYellow = 0;
        public int compteurGreen = 0;
        public Cell(string genetic)
        {
            size = 10;
            color = Color.Black;
            this.genetic = genetic;
        }
        public void Mutation()
        {

            Random rnd = new Random();
            List<char> geneticList = new List<char>(genetic);
            char[] ACTG = { 'A', 'C', 'T', 'G' };

            for (int i = 0; i < geneticList.Count; i++)
            {
                int prob = rnd.Next(0, 100);
                int prob5Pc = rnd.Next(0, 100);
                int probChoice = rnd.Next(0, 4);

                if (geneticList[i] == 'A' && prob <= 15)
                {
                    geneticList.Add('T');
                    if (prob5Pc <= 5)
                    {
                        geneticList.Add(ACTG[probChoice]);
                    }
                }
                else if (geneticList[i] == 'T' && prob <= 7)
                {
                    geneticList.Add('A');
                    geneticList.Add('A');
                    if (prob5Pc <= 5)
                    {
                        geneticList.Add(ACTG[probChoice]);
                    }
                }
                else if (geneticList[i] == 'C' && prob <= 21)
                {
                    geneticList.Add('G');
                    if (prob5Pc <= 5)
                    {
                        geneticList.Add(ACTG[probChoice]);
                    }
                }
                else if (geneticList[i] == 'G' && prob <= 4)
                {
                    geneticList.Add('C');
                    geneticList.Add('G');
                    if (prob5Pc <= 5)
                    {
                        geneticList.Add(ACTG[probChoice]);
                    }
                }
            }

            UpdateGenetic(geneticList);
            UpdateColor();

            size = 10 + (genetic.Length / 5) + Math.Min(genetic.Count(c => c == 'T'), size);
        }

        public void UpdateGenetic(List<char> geneticList)
        {

            // Mise à jour de la chaîne génétique
            genetic = new string(geneticList.ToArray());
            Debug.Print(genetic);
            for (int i = 0; i <= genetic.Length - 3; i += 3)
            {
                string triplet = genetic.Substring(i, 3);

                switch (triplet)
                {
                    case "ATT":
                        compteurBleu += 1;
                        break;

                    case "CTC":
                        compteurYellow += 1;
                        break;

                    case "ACT":
                        compteurViolet += 1;
                        break;
                    case "GTC":
                        compteurOrange += 1;
                        break;
                    case "GAA":
                        compteurGreen += 1;
                        break;
                    case "TGT":
                        compteurBLack += 1;

                        break;

                }


            }

        }

        public void UpdateColor()
        {
            int[] maxIterence = { compteurBLack, compteurBleu, compteurGreen, compteurOrange, compteurViolet, compteurYellow };
            int total = maxIterence.Max();

            if (total == compteurViolet)
            {
                color = Color.Violet;
            }
            else if (total == compteurBleu)
            {
                color = Color.Blue;
            }
            else if (total == compteurYellow)
            {
                color = Color.Yellow;
            }
            else if (total == compteurOrange)
            {
                color = Color.Orange;
            }
            else if (total == compteurGreen)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Black; // Couleur par défaut
            }

        }
    }
}
