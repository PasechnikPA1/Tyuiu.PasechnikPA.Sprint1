﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PasechnikPA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            
            
            char firstChar = value[0];
            value = value + firstChar;
            return value;
            
        }
    }
}
