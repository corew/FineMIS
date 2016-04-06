﻿using System;
using System.Web.UI;
using FineUI;

namespace FineMIS.Pages
{
    public partial class Page : MasterPage
    {
        public ISinglePageBase PageBase => (ISinglePageBase)Page;

        public Window Window => Window1;

        protected void Page_Init(object sender, EventArgs e)
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            var argument = Request.Params["__EVENTARGUMENT"];
            PageBase.ProcessArgument(argument);
        }
    }
}