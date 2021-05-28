using System;
using System.Collections.Generic;

namespace G4HE.Views.Print
{
    /// <summary>
    /// Uses set cursor position to draw out the menus to the console.
    /// </summary>
    public static class DrawFrames
    {
        private static int Left, Top;

        /// <summary>
        /// Call to draw menu with frames with desired message with numbers.
        /// example:
        /// ╔════════════════════════════════╗
        /// ║ 1: Your text here...           ║
        /// ╚════════════════════════════════╝
        /// </summary>
        /// <param name="options"></param>
        internal static void DisplayMenu(List<string> options)
        {
            DrawMenuFrame(options);
            DrawMenuOptions(options);
        }

        /// <summary>
        /// Call to draw menu with frames with desired message.
        /// example:
        /// ╔════════════════════════════════╗
        /// ║ Your text here...              ║
        /// ╚════════════════════════════════╝
        /// </summary>
        /// <param name="options"></param>
        internal static void DisplayMenuNoNumbers(List<string> options)
        {
            DrawMenuFrame(options);
            DrawMenuOptionsNoNumbers(options);
        }

        /// <summary>
        /// Draws the menu frames using set cursor position.
        /// </summary>
        /// <param name="options">Depending on how many strings you put in
        /// the frames will scale the size of the frame accordingly.</param>
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

        /// <summary>
        /// Draws the input inside the frame with numbers.
        /// </summary>
        /// <param name="options">The List<string> input.</string></param>
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

        /// <summary>
        /// Draws the input inside the frame.
        /// </summary>
        /// <param name="options">The List<string> input.</string></param>
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
