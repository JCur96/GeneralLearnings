//ButtonPusher

using System;
namespace StillOnlineApplet
{
    class ButtonPusher
    {
        public void buttonPusher(int randomSeed)
        {
            if (randomSeed % 2 == 0)
            {
                SendKeys.Send("{RMB}");
            }
            else
            {
                SendKeys.Send("{ENTER}");
            }
            //SendKeys.Send("{F13}");

           

            
        }
    }
}