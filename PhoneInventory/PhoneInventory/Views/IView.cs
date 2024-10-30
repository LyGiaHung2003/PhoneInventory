﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneWarehouse.Models;

namespace PhoneWarehouse.Views
{
    interface IView
    {
        public void SetDataToText(Object item);
        public void GetDataFromText();
    }
}
