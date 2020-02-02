using System;
namespace PokeTypes
{
    public class Types
    {

        public static double GetEffectiveness(string a, string d)
        {
            double i = 1;
            a = a.ToLower();
            d = d.ToLower();

            if(a == "normal")
            {
                if (d == "ghost") i = 0;
                if (d == "steel") i = .5;
                if (d == "rock") i = .5;
            }
            else if (a == "fire")
            {
                if (d == "fire") i = .5;
                if (d == "water") i = .5;
                if (d == "rock") i = .5;
                if (d == "dragon") i = .5;
                if (d == "grass") i = 2;
                if (d == "ice") i = 2;
                if (d == "bug") i = 2;
                if (d == "steel") i = 2;
            }
            else if (a == "water")
            {
                if (d == "water") i = .5;
                if (d == "grass") i = .5;
                if (d == "dragon") i = .5;
                if (d == "fire") i = 2;
                if (d == "ground") i = 2;
                if (d == "rock") i = 2;
            }
            else if (a == "electric")
            {
                if (d == "xxxxxxxx") i /= 2;
                if (d == "xxxxxxxx") i /= 2;
                if (d == "xxxxxxxx") i *= 2;
            }

            return i;
        }
    }
}
