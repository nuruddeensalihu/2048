﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    public class GameModel
    {
        //Our model, basically properties tha would be required throut the project
        public static int Score { get; set; }
        public static bool isGameOver { get; set; }
        public static bool isAuthorized { get; set; }
    }
}
