﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public T Value { get; private set; }

        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().Name}: {this.Value}";
        }
    }
}
