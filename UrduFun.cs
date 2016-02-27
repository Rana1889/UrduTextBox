using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UrduTextBox
{
    class UrduFun
    {
        #region " Urdu Functions "

        public static string TypeUrdu(TextBox textBox, char ch)
        {
            if (textBox == null) return String.Empty;
            int cursorPosition = textBox.SelectionStart;
            int startIndex = textBox.Text.Length - cursorPosition;
            string text1 = textBox.Text.Substring(0, cursorPosition);
            string text2 = String.Empty;
            text2 = textBox.Text.Substring(cursorPosition, textBox.Text.Length - cursorPosition);
            StringBuilder sb = new StringBuilder(text1);
            switch (ch)
            {
                case 'a': sb.Append("\u0627"); break;
                case 'b': sb.Append("\u0628"); break;
                case 'c': sb.Append("\u0686"); break;
                case 'd': sb.Append("\u062F"); break;
                case 'e': sb.Append("\u0639"); break;
                case 'f': sb.Append("\u0641"); break;
                case 'g': sb.Append("\u06AF"); break;
                case 'h': sb.Append("\u06BE"); break;
                case 'i': sb.Append("\u06CC"); break;
                case 'j': sb.Append("\u062C"); break;
                case 'k': sb.Append("\u06A9"); break;
                case 'l': sb.Append("\u0644"); break;
                case 'm': sb.Append("\u0645"); break;
                case 'n': sb.Append("\u0646"); break;
                case 'o': sb.Append("\u06C1"); break;
                case 'p': sb.Append("\u067E"); break;
                case 'q': sb.Append("\u0642"); break;
                case 'r': sb.Append("\u0631"); break;
                case 's': sb.Append("\u0633"); break;
                case 't': sb.Append("\u062A"); break;
                case 'u': sb.Append("\u0626"); break;
                case 'v': sb.Append("\u0637"); break;
                case 'w': sb.Append("\u0648"); break;
                case 'x': sb.Append("\u0634"); break;
                case 'y': sb.Append("\u06D2"); break;
                case 'z': sb.Append("\u0632"); break;

                case 'A': sb.Append("\u0622"); break;
                case 'B': sb.Append("\u0628"); break;
                case 'C': sb.Append("\u062B"); break;
                case 'D': sb.Append("\u0688"); break;
                case 'E': sb.Append("\u0651"); break;
                case 'F': sb.Append("\u064D"); break;
                case 'G': sb.Append("\u063A"); break;
                case 'H': sb.Append("\u062D"); break;
                case 'I': sb.Append("\u0670"); break;
                case 'J': sb.Append("\u0636"); break;
                case 'K': sb.Append("\u062E"); break;
                case 'L': sb.Append("\u0628"); break;
                case 'M': sb.Append("\u064B"); break;
                case 'N': sb.Append("\u06BA"); break;
                case 'O': sb.Append("\u06C3"); break;
                case 'P': sb.Append("\u064F"); break;
                case 'Q': sb.Append("\u0628"); break;
                case 'R': sb.Append("\u0691"); break;
                case 'S': sb.Append("\u0635"); break;
                case 'T': sb.Append("\u0679"); break;
                case 'U': sb.Append("\u0621"); break;
                case 'V': sb.Append("\u0638"); break;
                case 'W': sb.Append("\u0624"); break;
                case 'X': sb.Append("\u0698"); break;
                case 'Z': sb.Append("\u0630"); break;

                case '>': sb.Append("\u0650"); break;
                case '<': sb.Append("\u064E"); break;
                case ':': sb.Append("\u061B"); break;
                case '!': sb.Append("\u0021"); break;
                case '?': sb.Append("\u061F"); break;

                case '[': sb.Append("\u0654"); break;
                case '~': sb.Append("\u0653"); break;
                case '^': sb.Append("\u0652"); break;
                case '/': sb.Append("\u002F"); break;
                case '+': sb.Append("\u002B"); break;
                case '-': sb.Append("\u002D"); break;
                case '*': sb.Append("\u00D7"); break;
                case '(': sb.Append("\u0028"); break;
                case ')': sb.Append("\u0029"); break;
                case ' ': sb.Append(" "); break;
                case '\b': if (sb.Length > 0) sb.Remove(sb.Length - 1, 1); break;
                default: sb.Append(ch.ToString()); break;
            }
            textBox.Text = sb.ToString() + text2;
            textBox.SelectionStart = sb.Length;
            return sb.ToString();
        }

        public static string TypeUrdu_Alpha(TextBox textBox, char ch)
        {
            StringBuilder sb = new StringBuilder(textBox.Text);
            switch (ch)
            {
                case 'a': sb.Append("\u0627"); break;
                case 'b': sb.Append("\u0628"); break;
                case 'c': sb.Append("\u0686"); break;
                case 'd': sb.Append("\u062F"); break;
                case 'e': sb.Append("\u0639"); break;
                case 'f': sb.Append("\u0641"); break;
                case 'g': sb.Append("\u06AF"); break;
                case 'h': sb.Append("\u06BE"); break;
                case 'i': sb.Append("\u06CC"); break;
                case 'j': sb.Append("\u062C"); break;
                case 'k': sb.Append("\u06A9"); break;
                case 'l': sb.Append("\u0644"); break;
                case 'm': sb.Append("\u0645"); break;
                case 'n': sb.Append("\u0646"); break;
                case 'o': sb.Append("\u06C1"); break;
                case 'p': sb.Append("\u067E"); break;
                case 'q': sb.Append("\u0642"); break;
                case 'r': sb.Append("\u0631"); break;
                case 's': sb.Append("\u0633"); break;
                case 't': sb.Append("\u062A"); break;
                case 'u': sb.Append("\u0626"); break;
                case 'v': sb.Append("\u0637"); break;
                case 'w': sb.Append("\u0648"); break;
                case 'x': sb.Append("\u0634"); break;
                case 'y': sb.Append("\u06D2"); break;
                case 'z': sb.Append("\u0632"); break;

                case 'A': sb.Append("\u0622"); break;
                case 'B': sb.Append("\u0628"); break;
                case 'C': sb.Append("\u062B"); break;
                case 'D': sb.Append("\u0688"); break;
                case 'E': sb.Append("\u0651"); break;
                case 'F': sb.Append("\u064D"); break;
                case 'G': sb.Append("\u063A"); break;
                case 'H': sb.Append("\u062D"); break;
                case 'I': sb.Append("\u0670"); break;
                case 'J': sb.Append("\u0636"); break;
                case 'K': sb.Append("\u062E"); break;
                case 'L': sb.Append("\u0628"); break;
                case 'M': sb.Append("\u064B"); break;
                case 'N': sb.Append("\u06BA"); break;
                case 'O': sb.Append("\u06C3"); break;
                case 'P': sb.Append("\u064F"); break;
                case 'Q': sb.Append("\u0628"); break;
                case 'R': sb.Append("\u0691"); break;
                case 'S': sb.Append("\u0635"); break;
                case 'T': sb.Append("\u0679"); break;
                case 'U': sb.Append("\u0621"); break;
                case 'V': sb.Append("\u0638"); break;
                case 'W': sb.Append("\u0624"); break;
                case 'X': sb.Append("\u0698"); break;
                case 'Z': sb.Append("\u0630"); break;

                case '>': sb.Append("\u0650"); break;
                case '<': sb.Append("\u064E"); break;
                case ':': sb.Append("\u061B"); break;
                case '!': sb.Append("\u0021"); break;
                case '?': sb.Append("\u061F"); break;

                case '[': sb.Append("\u0654"); break;
                case '~': sb.Append("\u0653"); break;
                case '^': sb.Append("\u0652"); break;
                case '/': sb.Append("\u002F"); break;
                case '+': sb.Append("\u002B"); break;
                case '-': sb.Append("\u002D"); break;
                case '*': sb.Append("\u00D7"); break;
                case '(': sb.Append("\u0028"); break;
                case ')': sb.Append("\u0029"); break;
                case ' ': sb.Append(" "); break;
                case '\b': if (sb.Length > 0) sb.Remove(sb.Length - 1, 1); break;
                default: sb.Append(ch.ToString()); break;
            }
            textBox.Text = sb.ToString();
            textBox.SelectionStart = textBox.Text.Length;
            return sb.ToString();
        }

        #endregion

    }
}
