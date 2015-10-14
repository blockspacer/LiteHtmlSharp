﻿using System;
using LiteHtmlSharp;
using CoreGraphics;
using AppKit;

namespace MacTest
{
   public static class LiteHtmlMacExtensions
   {
      public static CGRect ToRect(this position pos)
      {
         return new CGRect(pos.x, pos.y, pos.width, pos.height);
      }

      public static position ToPosition(this CGRect rect)
      {
         return new position
         { 
            width = (int)Math.Round(rect.Width), 
            height = (int)Math.Round(rect.Height), 
            x = (int)Math.Round(rect.X), 
            y = (int)Math.Round(rect.Y) 
         };
      }

      const float MaxByteAsFloat = (float)byte.MaxValue;

      public static CGColor ToCGColor(this web_color wc)
      {
         return new CGColor(wc.red / MaxByteAsFloat, wc.green / MaxByteAsFloat, wc.blue / MaxByteAsFloat, wc.alpha / MaxByteAsFloat);
      }

      public static NSColor ToNSColor(this web_color wc)
      {
         return NSColor.FromRgba(wc.red / MaxByteAsFloat, wc.green / MaxByteAsFloat, wc.blue / MaxByteAsFloat, wc.alpha / MaxByteAsFloat);
      }
   }
}

