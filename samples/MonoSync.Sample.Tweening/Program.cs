﻿using System;

namespace MonoSync.Sample.Tweening
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            using var game = new MainGame();
            game.Run();
        }
    }
}