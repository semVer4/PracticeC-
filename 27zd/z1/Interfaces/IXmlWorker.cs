﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.Interfaces
{
    internal class IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Country country);
        void Delete(string name);
        Country FindBy(string name);
        List<Country> GetAll();
    }
}
