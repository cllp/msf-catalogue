﻿using MSF.LogisticsPlatform.BusinessLayer.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public interface IFilterService
    {
        Filter GetFilter(string category);
    }
}