using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
namespace LnDCSharpProj1
{
    class TextWrap
    {
        // This class has been written to specifically apply to my ToDo list, so will not work as a generic.
        // I may update this in the future if I have need of text wrapping more generally.
        public string WrapText(string textToWrap)
        {
            // This method removes all whitespace including newline carriage returns. 
            // This is extreme but done as passing a string literal '@".."' causes issues with
            // extraneous new lines, and means the end result is poorly formatted. 
            // As this is used only on my ToDo as of the 08/04/21 I have used the consistent nature 
            // of the ToDo input to re-insert newlines for pretty formatting. 

            // do some sanitisation in here (i.e. put spaces after stops. 
            //textToWrap = Regex.Replace(textToWrap, @"\.\w", @".\un\w"); // needs work, currently replaces with the literal

            int LineLenghtChars = 80;
            string[] words = textToWrap.Split(' ');
            StringBuilder wrappedText = new StringBuilder();
            string line = string.Empty;

            foreach (string word in words)
            {
                var nextLength = (line + word).Length;
                // if the current length plus the next word is over limit
                // add just the line, then reset to empty. 
                if (nextLength > LineLenghtChars || line.Contains(".")) // add logic so that if the end of a sentence is hit, move onto the next line.
                {
                    wrappedText.AppendLine(line);
                    wrappedText.Append('\t', 1); // append a tab to align the text better?
                    line = string.Empty;
                }
                // otherwise add the word to the line
                line += string.Format("{0} ", word);

            }

            if (line.Length > 0)
                wrappedText.AppendLine(line);
            string stringWrappedText = wrappedText.ToString();
            return stringWrappedText;
        }
    }
}
