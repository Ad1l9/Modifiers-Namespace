﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers_Namespace.Models
{
    internal class Assistant:Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccesfull) GetPromotion(employee);
        }
    }
}
