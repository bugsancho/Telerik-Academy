using System;
class FighterAttack
    {
        static void Main(string[] args)
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine());
            int Py2 = int.Parse(Console.ReadLine());
            int Fx = int.Parse(Console.ReadLine());
            int Fy = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int maxPx = Math.Max(Px1,Px2);
            int maxPy = Math.Max(Py1, Py2);
            int minPx = Math.Min(Px1, Px2);
            int minPy = Math.Min(Py1, Py2);
            int score = 0;

            if ((((Fx + D) <= (maxPx)) && ((Fx + D) >= minPx)) && ((Fy <= maxPy) && (Fy >= minPy)))
            {
                score += 100;
            }
            if ((((Fx + D+1) <= (maxPx)) && ((Fx + D+1) >= minPx)) && ((Fy <= maxPy) && (Fy >= minPy)))
            {
                score += 75;
            }
            if ((((Fx + D) <= (maxPx)) && ((Fx + D) >= minPx)) && ((Fy +1 <= maxPy) && (Fy +1 >= minPy)))
            {
                score += 50;
            }
            if ((((Fx + D) <= (maxPx)) && ((Fx + D) >= minPx)) && ((Fy -1 <= maxPy) && (Fy -1 >= minPy)))
            {
                score += 50;
            }
            Console.WriteLine("{0}%",score);
        }
    }

