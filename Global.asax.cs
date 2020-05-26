using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GuitarLessons
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            OneDay.MaxNumOfSongs = 2;
            OneDay.MaxTotalComplexity = 3;
            TwoDays.MaxNumOfSongs = 3;
            TwoDays.MaxTotalComplexity = 7;
            ThreeDays.MaxNumOfSongs = 4;
            ThreeDays.MaxTotalComplexity = 10;
        }
    }
}