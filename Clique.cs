using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DeftSharp.Windows.Input.Keyboard;
using DeftSharp.Windows.Input.Mouse;
using Microsoft.VisualBasic.Devices;

namespace WinFormsApp1
{
    public class Clique
    {
        public static void Mouse()
        {
            var mouse = new MouseManipulator();

            mouse.DoubleClick();
        }

        public static async Task Clicar()
        {
            while (true)
            {
                await Task.Delay(500);
                Mouse();
                await Task.Delay(800);
                Mouse();

                var keyboard = new KeyboardListener();

                keyboard.SubscribeOnce(Key.X, key => Application.Exit());
            }
            
        }
    }
}