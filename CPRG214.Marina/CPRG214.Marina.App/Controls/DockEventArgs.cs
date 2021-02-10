using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPRG214.Marina.App.Controls
{
    public class DockEventArgs :EventArgs 
    {
        //Code written by Julie Tran
        //Last Modified Febuary 7 2021
        public int ID { get; set; }
        public string Name { get; set; }
        public bool WaterService { get; set; }
        public bool ElectricalService { get; set; }
    }
}