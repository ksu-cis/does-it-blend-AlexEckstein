﻿using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendables = new List<IBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());
            //Add 10 Mangos
            for (int i = 0; i < 10; i++)
                blendables.Add(new Mango());

            Banana b = new Banana();
            Console.WriteLine(b.Blend());
            blendables.Add(b);

            // Print all items in list
            foreach (IBlendable blendable in blendables)
            {
               Console.WriteLine(blendable.Blend());
            }
            
        }
    }
}
