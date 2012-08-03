using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Spryt
{
    class LineRasterEnumerator : IEnumerator<Point>
    {
        public readonly Point Start;
        public readonly Point End;

        private bool mySteep;

        private int myDX;
        private int myDY;

        private float myDError;

        private int myYStep;

        private int myX;
        private int myY;

        private float myError;

        public LineRasterEnumerator( Point start, Point end )
        {
            mySteep = Math.Abs( end.X - start.X ) < Math.Abs( end.Y - start.Y );

            if ( !mySteep )
            {
                Start = start;
                End = end;
            }
            else
            {
                Start = new Point( start.Y, start.X );
                End = new Point( end.Y, end.X );
            }

            if ( Start.X > End.X )
            {
                Point temp = End;
                End = Start;
                Start = temp;
            }

            myDX = End.X - Start.X;
            myDY = Math.Abs( End.Y - Start.Y );

            myDError = (float) myDY / myDX;

            myYStep = Math.Sign( End.Y - Start.Y );

            Reset();
        }

        public Point Current
        {
            get;
            private set;
        }

        public void Dispose()
        {
            return;
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            if ( myX > End.X )
                return false;

            if ( mySteep )
                Current = new Point( myY, myX );
            else
                Current = new Point( myX, myY );

            myError += myDError;

            if ( myError >= 0.5f )
            {
                myY += myYStep;
                myError -= 1.0f;
            }

            ++myX;
            return true;
        }

        public void Reset()
        {
            myX = Start.X;
            myY = Start.Y;
            myError = 0.0f;
        }
    }
}
