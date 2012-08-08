using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Spryt
{
    class ActionStack
    {
        public EditAction First { get; private set; }
        public EditAction Current { get; private set; }

        public void Push( EditAction action )
        {
            if ( First == null )
                First = action;
            else
                Current.SetNext( action );

            Current = action;
        }

        public void Undo()
        {
            if ( Current != First )
            {
                Current = Current.PreviousAction;
                Current.Undo();
            }
        }

        public void Redo()
        {
            if ( Current != null && Current.NextAction != null )
            {
                Current = Current.NextAction;
                Current.Redo();
            }
        }
    }

    abstract class EditAction
    {
        protected readonly ImageInfo Image;

        public EditAction NextAction { get; private set; }
        public EditAction PreviousAction { get; private set; }

        public EditAction( ImageInfo image )
        {
            Image = image;

            PreviousAction = null;
            NextAction = null;
        }

        public void SetNext( EditAction action )
        {
            NextAction = action;
            action.PreviousAction = this;
        }

        public abstract void Undo();
        public abstract void Redo();
    }

    class ActionAnchor : EditAction
    {
        private Size mySize;
        private String[] myLayerLabels;
        private Pixel[][,] myLayerPixels;
        private Color[] myPalette;

        public ActionAnchor( ImageInfo image )
            : base( image )
        {
            mySize = image.Size;
            myLayerLabels = image.Layers.Select( x => x.Label ).ToArray();
            myLayerPixels = image.Layers.Select( x => (Pixel[,]) x.Pixels.Clone() ).ToArray();
            myPalette = (Color[]) image.Palette.Clone();
        }

        public override void Undo()
        {
            // Resize when implemented
            Image.Layers.Clear();
            for ( int i = 0; i < myLayerLabels.Length; ++i )
            {
                Image.Layers.Add( new Layer( Image, myLayerLabels[ i ] ) );
                for ( int x = 0; x < mySize.Width; ++x )
                    for ( int y = 0; y < mySize.Height; ++y )
                        Image.Layers[ i ].SetPixel( x, y, myLayerPixels[ i ][ x, y ] );
            }

            Image.UpdateLayers();
            Image.Palette = (Color[]) myPalette.Clone();
        }

        public override void Redo()
        {
            Undo();
        }
    }

    class EditLayerAction : EditAction
    {
        private int myLayerIndex;
        private Pixel[,] myPixels;

        public EditLayerAction( ImageInfo image, Layer layer )
            : base( image )
        {
            myLayerIndex = image.Layers.IndexOf( layer );
            myPixels = (Pixel[,]) layer.Pixels.Clone();
        }

        public override void Undo()
        {
            for ( int x = 0; x < Image.Width; ++x )
                for ( int y = 0; y < Image.Height; ++y )
                    Image.Layers[ myLayerIndex ].SetPixel( x, y, myPixels[ x, y ] );

            Image.Canvas.SendImageChange();
        }

        public override void Redo()
        {
            Undo();
        }
    }

    class AddLayerAction : EditAction
    {
        private int myLayerIndex;
        private String myLabel;

        public AddLayerAction( ImageInfo image, Layer layer )
            : base( image )
        {
            myLayerIndex = image.Layers.IndexOf( layer );
            myLabel = layer.Label;
        }

        public override void Undo()
        {
            Image.Layers.RemoveAt( myLayerIndex );
            Image.UpdateLayers();
        }

        public override void Redo()
        {
            Image.Layers.Insert( myLayerIndex, new Layer( Image, myLabel ) );
            Image.UpdateLayers();
        }
    }

    class RemoveLayerAction : EditAction
    {
        private int myLayerIndex;
        private String myLabel;
        private Pixel[ , ] myPixels;

        public RemoveLayerAction( ImageInfo image, int index, Layer layer )
            : base( image )
        {
            myLayerIndex = index;
            myLabel = layer.Label;
            myPixels = (Pixel[,]) layer.Pixels.Clone();
        }

        public override void Undo()
        {
            Image.Layers.Insert( myLayerIndex, new Layer( Image, myLabel ) );
            for ( int x = 0; x < Image.Width; ++x )
                for ( int y = 0; y < Image.Height; ++y )
                    Image.Layers[ myLayerIndex ].SetPixel( x, y, myPixels[ x, y ] );

            Image.UpdateLayers();
        }

        public override void Redo()
        {
            Image.Layers.RemoveAt( myLayerIndex );
            if ( Image.Layers.Count == 0 )
                Image.Layers.Add( new Layer( Image ) );

            Image.UpdateLayers();
        }
    }
}
