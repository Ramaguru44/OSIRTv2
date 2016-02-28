﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSIRT.Browser
{
    public class BrowserTab : TabPage
    {
        public ExtendedBrowser Browser { get; private set; }
        public string CurrentURL { get; set; }

        public BrowserTab() : base()
        {
            Browser = new ExtendedBrowser();
            Browser.Dock = DockStyle.Fill;
            Browser.DocumentTitleChanged += Browser_DocumentTitleChanged;
           

            Controls.Add(Browser);
        }

      

        void Browser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = Browser.DocumentTitle;
        }

    }
}