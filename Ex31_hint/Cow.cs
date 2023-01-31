﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31
{
    class Cow : Character
    {
        public Cow(string name, float hp, float power) : base(name, hp, power) { }
        public override void Attack(Character destination)
        {
            if (hp >= 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}を角で突いた！");
                Console.WriteLine($"{destination.name}に傷がついた！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}はHP={this.hp}で足りないので攻撃できません！");
            }
        }
    }
}