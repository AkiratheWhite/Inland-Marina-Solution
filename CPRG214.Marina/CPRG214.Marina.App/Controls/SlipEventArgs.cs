using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPRG214.Marina.App.Controls
{
    public class SlipEventArgs: EventArgs
    {
        public int ID { get; set;  }
        public int Width { get; set; }
        public int Length { get; set; }
        public int DockID { get; set; }
    }
}