﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Rowland_Ethan
{
    internal class Game
    {

        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }

    }
}
