//Definately still online script
// Moves the mouse at semi-random intervals
// Also hits ESC and F13 keys semi-randomly

using System;

namespace StillOnlineApplet
{
    class Program
    {  
        [STAThreadAttribute]
        static void Main()
        {
            var rand = new Random();
            var  bytes = new byte[3];
            rand.NextBytes(bytes);

            new var pushButtons = new ButtonPusher;
            MouseMover moveMouse;
            bool keepRunning = true;
            while(keepRunning) // change to have not keyboard interrupt?
            {
                pushButtons.buttonPusher(bytes[0]);
                //call methods from mouse mover
                // and button pusher
                moveMouse.mouseMover(bytes[1], bytes[2]);

                if (Console.ReadKey == 'ESC')
                {
                    keepRunning = false;
                }
            }
        }
    }
}