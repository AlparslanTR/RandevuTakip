﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RandevuTakip
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGiris());
        }
    }
}
