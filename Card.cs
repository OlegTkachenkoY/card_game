using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Karciana_Projekt_MULKA_PETRYLA_TKACHENKO
{
    class Card
    {
        string name;
        int hp;
        int attack;
        string text;

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Attack { get => attack; set => attack = value; }
        public string Text { get => text; set => text = value; }

        public Card()
        {
                
        }

        public Card(string name, int hp, int attack, string text)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attack = attack;
            this.Text = text;
        }


    }
}
