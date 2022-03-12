using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Screens.Sale
{
    public sealed class ReceiptViewerAdapter
    {
        private StackPanel _Viewer;

        private StringBuilder _Source;
        private FontStyle _FontStyle;

        public FontStyle FontStyle
        {
            get { return _FontStyle; }
            set { _FontStyle = value; Refresh(); }
        }
        private FontFamily _FontFamily;

        public FontFamily FontFamily
        {
            get { return _FontFamily; }
            set { _FontFamily = value; Refresh(); }
        }
        private FontStretch _FontStretch;

        public FontStretch FontStretch
        {
            get { return _FontStretch; }
            set { _FontStretch = value; Refresh(); }
        }
        private FontWeight _FontWeight;

        public FontWeight FontWeight
        {
            get { return _FontWeight; }
            set { _FontWeight = value; Refresh(); }
        }
        public ReceiptViewerAdapter(StackPanel Viewer)
        {
            _Viewer = Viewer;
            _Viewer.Children.Clear();
            _FontFamily = new FontFamily("Lucida Sans Unicode");
            _FontStretch = FontStretches.Normal;
            _FontStyle = FontStyles.Normal;
            _FontWeight = FontWeights.Normal;
            _Source = new StringBuilder();
        }

        public StackPanel Viewer
        { get { return _Viewer; } }

        public StringBuilder Source
        {
            get { return _Source; }
        }

        public void Append(string text, int size = 12, TextAlignment align = TextAlignment.Left)
        {
            _Source.Append(text);
            if (_Viewer.Children.Count == 0)
            {
                Label l = new Label();
                _Viewer.Children.Add(l);
            }

            Label lastLine = (Label)_Viewer.Children[_Viewer.Children.Count - 1];

            string line = (string)lastLine.Content;
            line += text;
            lastLine.Content = line;

            if (align == TextAlignment.Left)
                lastLine.HorizontalAlignment = HorizontalAlignment.Left;
            else if (align == TextAlignment.Center)
                lastLine.HorizontalAlignment = HorizontalAlignment.Center;
            else if (align == TextAlignment.Right)
                lastLine.HorizontalAlignment = HorizontalAlignment.Right;
            else if (align == TextAlignment.Justify)
                lastLine.HorizontalAlignment = HorizontalAlignment.Stretch;

            lastLine.FontSize = size;
            lastLine.FontFamily = FontFamily;
            lastLine.FontStretch = FontStretch;
            lastLine.FontStyle = FontStyle;
            lastLine.FontWeight = FontWeight;
        }

        public void AppendLine(int size = 12, TextAlignment align = TextAlignment.Left)
        {
            _Source.AppendLine();
            Label l = new Label();
            _Viewer.Children.Add(l);
            l.FontSize = size;
            l.FontFamily = FontFamily;
            l.FontStretch = FontStretch;
            l.FontStyle = FontStyle;
            l.FontWeight = FontWeight;
        }
        public void AppendLine(string text, int size = 12, TextAlignment align = TextAlignment.Left)
        {
            _Source.AppendLine(text);
            Label l = new Label();
            _Viewer.Children.Add(l);
            l.FontSize = size;
            l.FontFamily = FontFamily;
            l.FontStretch = FontStretch;
            l.FontStyle = FontStyle;
            l.FontWeight = FontWeight;
            Append(text, size, align);
            AppendLine(size, align);
        }

        public void Clear()
        {
            _Viewer.Children.Clear();
            _Source.Clear();
            _Source = new StringBuilder();
        }

        private void Refresh()
        {
            foreach (UIElement ele in _Viewer.Children)
            {
                Label l = (Label)ele;
                l.FontFamily = FontFamily;
                l.FontStretch = FontStretch;
                l.FontStyle = FontStyle;
                l.FontWeight = FontWeight;
            }
        }
    }
}
