﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LiteHtmlSharp
{
   [StructLayout(LayoutKind.Sequential)]
   public struct position
   {
      public int x;
      public int y;
      public int width;
      public int height;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct border_radiuses
   {
      public int top_left_x;
      public int top_left_y;

      public int top_right_x;
      public int top_right_y;

      public int bottom_right_x;
      public int bottom_right_y;

      public int bottom_left_x;
      public int bottom_left_y;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct borders
   {
      public border left;
      public border top;
      public border right;
      public border bottom;
      public border_radiuses radius;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct border
   {
      public int width;
      public border_style style;
      public web_color color;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct web_color
   {
      public byte blue;
      public byte green;
      public byte red;
      public byte alpha;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct size
   {
      public int width;
      public int height;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct font_metrics
   {
      public int height;
      public int ascent;
      public int descent;
      public int x_height;
      public bool draw_spaces;
   }

   [StructLayout(LayoutKind.Sequential)]
   public struct media_features
   {
      public media_type type;
      public int width;        // (pixels) For continuous media, this is the width of the viewport including the size of a rendered scroll bar (if any). For paged media, this is the width of the page box.
      public int height;       // (pixels) The height of the targeted display area of the output device. For continuous media, this is the height of the viewport including the size of a rendered scroll bar (if any). For paged media, this is the height of the page box.
      public int device_width; // (pixels) The width of the rendering surface of the output device. For continuous media, this is the width of the screen. For paged media, this is the width of the page sheet size.
      public int device_height;   // (pixels) The height of the rendering surface of the output device. For continuous media, this is the height of the screen. For paged media, this is the height of the page sheet size.
      public int color;        // The number of bits per color component of the output device. If the device is not a color device, the value is zero.
      public int color_index;  // The number of entries in the color lookup table of the output device. If the device does not use a color lookup table, the value is zero.
      public int monochrome;      // The number of bits per pixel in a monochrome frame buffer. If the device is not a monochrome device, the output device value will be 0.
      public int resolution;      // The resolution of the output device (in DPI)
   };

   public enum media_type
   {
      media_type_none,
      media_type_all,
      media_type_screen,
      media_type_print,
      media_type_braille,
      media_type_embossed,
      media_type_handheld,
      media_type_projection,
      media_type_speech,
      media_type_tty,
      media_type_tv,
   }

   public enum border_style
   {
      border_style_none,
      border_style_hidden,
      border_style_dotted,
      border_style_dashed,
      border_style_solid,
      border_style_double,
      border_style_groove,
      border_style_ridge,
      border_style_inset,
      border_style_outset
   }

   public enum background_repeat
   {
      background_repeat_repeat,
      background_repeat_repeat_x,
      background_repeat_repeat_y,
      background_repeat_no_repeat
   }

   public enum font_style
   {
      fontStyleNormal,
      fontStyleItalic
   }

   public enum font_variant
   {
      font_variant_normal,
      font_variant_italic
   }
}
