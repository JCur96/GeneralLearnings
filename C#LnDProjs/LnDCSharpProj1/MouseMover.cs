//Mouse mover

using System;

namespace StillOnlineApplet
{
    class MouseMover
    {
        public void mouseMover(int newPositionX, int newPositionY)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X = newPositionX, Cursor.Position.Y = newPositionY);
        }
    }
}