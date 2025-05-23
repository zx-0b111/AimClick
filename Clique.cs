using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DeftSharp.Windows.Input.Keyboard;
using DeftSharp.Windows.Input.Mouse;

namespace WinFormsApp1
{
    public class Clique
    {
        public static void Mouse()
        {
            var mouse = new MouseManipulator();

            mouse.DoubleClick();
            mouse.DoubleClick();
            mouse.DoubleClick();
            mouse.DoubleClick();
            mouse.DoubleClick();
            mouse.DoubleClick();
            mouse.DoubleClick();
            mouse.DoubleClick();
        }
        
        public static void EncerraPrograma()
        {
            Application.Exit();
        }
        public static async Task Clicar()
        {
            while (true)
            {
                await Task.Delay(400);
                Mouse();
                await Task.Delay(700);
                Mouse();
            }
            
        }
    }
}