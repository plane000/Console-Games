﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Games {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;

            UserInterface ui = new UserInterface();
            ui.atLaunch();
        }
    }
}
