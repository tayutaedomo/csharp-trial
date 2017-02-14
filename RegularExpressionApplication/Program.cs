﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressionApplication
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			func();
			func2();

			sample();
			sample2();
		}

		public static void func()
		{
			string str = "LS0MQxoT1ay8bQBtkBNb_abc.jpg";

			Regex reg = new Regex(@"(?<a>[0-9a-zA-Z]{20})_.+\.(?<b>.+)");

            Console.WriteLine(reg.IsMatch(str));

			MatchCollection mc = reg.Matches(str);

            Console.WriteLine(mc.Count);
            Console.WriteLine(mc[0].Value);

			//if (mc.Count > 0)
			if (mc.Count > 0)
			{
				GroupCollection group = mc[0].Groups;
				for (int i = 0; i < group.Count; i++)
				{
            		Console.WriteLine(i + ": " + group[i].Value);
				}
			}
		}

		public static void func2()
		{
			// See: https://www.wareko.jp/wordpress/?p=16899

			string str = "LS0MQxoT1ay8bQBtkBNb_abc.jpg";

			Regex reg = new Regex(@"(?<a>[0-9a-zA-Z]{20})_.+\.(?<b>.+)");

			Match match = reg.Match(str);

			while (match.Success)
			{
				GroupCollection groups = match.Groups;
				for (int i = 0; i < groups.Count; i++)
				{
            		Console.WriteLine(i + ": " + groups[i].Value);
				}

				match = match.NextMatch();
			}
		}

		public static void sample()
		{
			// See: http://www.kisoplus.com/sample2/seiki.html

			Regex reg = new Regex("[a-z]");
			string ui = reg.Replace("123abc456vrtldef789", "");
            Console.WriteLine(ui);
		}

		public static void sample2()
		{
			// See: http://unitylab.wiki.fc2.com/wiki/%E6%AD%A3%E8%A6%8F%E8%A1%A8%E7%8F%BE

//			string time = "";
//			MatchCollection mc;
//			mc = Regex.Matches (time, @"\d{1,}(?=時)|\d{1,}(?=分)|\d\d*\.\d{1,}(?=秒)");
//            foreach (Match item in mc) {
//                print (string.Format ("{0}:{1}", item.Value, item.Index));
//            }
//			minuteHand = int.Parse (mc [0].Value);
//			hourHand = int.Parse (mc [1].Value);
		}
	}
}

