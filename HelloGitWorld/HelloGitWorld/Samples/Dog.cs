﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitWorld.Samples
{
    public class Dog
    {
        /// <summary>
        /// Makes a sound.
        /// </summary>
        public void Bark()
        {
            // here comes the big one.
            Console.WriteLine("Woof!");
        }

        public void Meow()
        {
            throw new NotImplementedException();;
        }
    }
}
