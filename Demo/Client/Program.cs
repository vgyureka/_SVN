using Client.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            if (new LoginForm().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            {

            }
        }
    }
}
