﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(DictionaryEntry entry in Environment.GetEnvironmentVariables())
            {
                Response.Write(entry.Key + " : " + entry.Value);
                Response.Write("<br/>");
            }
        }
    }
}