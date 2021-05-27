﻿using System;
using System.Collections.Generic;

namespace G4HE.Views.Print
{
    public static class DrawFrames
    {
        private static int Left, Top;

        internal static void DisplayMenu(List<string> options)
        {
            DrawMenuFrame(options);
            DrawMenuOptions(options);
        }

        internal static void DisplayMenuNoNumbers(List<string> options)
        {
            DrawMenuFrame(options);
            DrawMenuOptionsNoNumbers(options);
        }

        private static void DrawMenuFrame(IReadOnlyCollection<string> options)
        {
            Left = 2;
            Top = 7;
            Console.SetCursorPosition(Left, Top);
            Console.WriteLine("╔════════════════════════════════╗");
            for (var i = 0; i < options.Count; i++)
            {
                Console.SetCursorPosition(Left, Top + i + 1);
                Console.WriteLine("║                                ║");
            }
            Console.SetCursorPosition(Left, Top + options.Count + 1);
            Console.WriteLine("╚════════════════════════════════╝");
        }

        private static void DrawMenuOptions(List<string> options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            var index = 1;
            foreach (var option in options)
            {
                Console.SetCursorPosition(Left + 2, Top + index);
                Console.WriteLine($"{index}: {option}");
                index++;
            }
            index++;
            Console.SetCursorPosition(Left = 0, Top + index);
        }

        private static void DrawMenuOptionsNoNumbers(IEnumerable<string> options)
        {
            var index = 1;
            foreach (var option in options)
            {
                Console.SetCursorPosition(Left + 2, Top + index);
                Console.WriteLine($"{option}");
                index++;
            }
            index++;
            Console.SetCursorPosition(Left = 0, Top + index);
        }
    }
}
