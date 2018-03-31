using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_NotifyEvent
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HideOnStartupApplicationContext(new Form1()));
        }
        internal class HideOnStartupApplicationContext : ApplicationContext
        {
            private Form mainFormInternal;

            public HideOnStartupApplicationContext(Form mainForm)
            {
                this.mainFormInternal = mainForm;
                this.mainFormInternal.FormClosed += new FormClosedEventHandler(mainFormInternal_FormClosed);
            }

            void mainFormInternal_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
            }
        }

    }
}
