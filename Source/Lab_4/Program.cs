﻿using Lab_4.DataBase;
using Lab_4.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
