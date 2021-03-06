﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using CoreGraphics;
using System.IO;
using System.Diagnostics;
using LiteHtmlSharp;
using LiteHtmlSharp.CoreGraphics;
using System.Text;

namespace LiteHtmlSharp.Mac
{
   public class LiteHtmlNSWindow : NSWindow
   {
      public CGContainer LiteHtmlContainer { get { return LiteHtmlView.LiteHtmlContainer; } }

      public LiteHtmlNSView LiteHtmlView { get { return windowHelper.LiteHtmlView; } }

      LiteHtmlWindowHelper windowHelper;

      public LiteHtmlNSWindow(CGRect rect, NSWindowStyle windowStyle, string masterCssData)
         : base(rect, windowStyle, NSBackingStore.Buffered, false)
      {
         windowHelper = new LiteHtmlWindowHelper(this, rect, masterCssData);
      }
   }
}
