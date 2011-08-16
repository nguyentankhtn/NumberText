﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberText {
    public class NumberText {

        private Dictionary<int, string> textStrings = new Dictionary<int, string>();

        public NumberText() {
            Initialize();
        }

        //TODO make this an extension method for the Integer object?
        public string ToText(int num) {
            var builder = new StringBuilder();

            if (num == 0) {
                builder.Append(textStrings[num]);
                return builder.ToString();
            }

            if (num > 20) {
                var tens = ((int) (num/10))*10;
                builder.AppendFormat("{0} ", textStrings[tens]);
                num = num - tens;
            }

            if (num > 0) {
                builder.Append(textStrings[num]);
            }

            return builder.ToString().Trim();
        }

        private void Initialize() {
            textStrings.Add(0, "zero");
            textStrings.Add(1, "one");
            textStrings.Add(2, "two");
            textStrings.Add(3, "three");
            textStrings.Add(4, "four");
            textStrings.Add(5, "five");
            textStrings.Add(6, "six");
            textStrings.Add(7, "seven");
            textStrings.Add(8, "eight");
            textStrings.Add(9, "nine");
            textStrings.Add(10, "ten");
            textStrings.Add(11, "eleven");
            textStrings.Add(12, "twelve");
            textStrings.Add(13, "thirteen");
            textStrings.Add(14, "fourteen");
            textStrings.Add(15, "fifteen");
            textStrings.Add(16, "sixteen");
            textStrings.Add(17, "seventeen");
            textStrings.Add(18, "eighteen");
            textStrings.Add(19, "nineteen");
            textStrings.Add(20, "twenty");
            textStrings.Add(30, "thirty");
            textStrings.Add(40, "forty");
            textStrings.Add(50, "fifty");
            textStrings.Add(60, "sixty");
            textStrings.Add(70, "seventy");
            textStrings.Add(80, "eighty");
            textStrings.Add(90, "ninety");
        }
    }
}
