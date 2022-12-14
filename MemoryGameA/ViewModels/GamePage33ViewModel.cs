using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace MemoryGameA.ViewModels
{
    public class GamePage33ViewModel : INotifyPropertyChanged
    {
        public GamePage33ViewModel()
        {
            Bitmap bmp1 = new Bitmap(@"Resources\MemoryGame_Image\Apple.png");
            IntPtr hbitmap1 = bmp1.GetHbitmap();
            Image1 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap1, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp2 = new Bitmap(@"Resources\MemoryGame_Image\Bear.png");
            IntPtr hbitmap2 = bmp2.GetHbitmap();
            Image2 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap2, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp3 = new Bitmap(@"Resources\MemoryGame_Image\Star.png");
            IntPtr hbitmap3 = bmp3.GetHbitmap();
            Image3 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap3, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp4 = new Bitmap(@"Resources\MemoryGame_Image\Banana.png");
            IntPtr hbitmap4 = bmp4.GetHbitmap();
            Image4 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap4, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp5 = new Bitmap(@"Resources\MemoryGame_Image\Bird.png");
            IntPtr hbitmap5 = bmp5.GetHbitmap();
            Image5 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap5, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp6 = new Bitmap(@"Resources\MemoryGame_Image\Apple.png");
            IntPtr hbitmap6 = bmp6.GetHbitmap();
            Image6 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap6, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp7 = new Bitmap(@"Resources\MemoryGame_Image\Bird.png");
            IntPtr hbitmap7 = bmp7.GetHbitmap();
            Image7 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap7, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp8 = new Bitmap(@"Resources\MemoryGame_Image\Bear.png");
            IntPtr hbitmap8 = bmp8.GetHbitmap();
            Image8 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap8, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp9 = new Bitmap(@"Resources\MemoryGame_Image\Banana.png");
            IntPtr hbitmap9 = bmp9.GetHbitmap();
            Image9 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap9, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

        public void doCommand(string p)
        {
            switch (p)
            {
                case "1":
                    ImageA = Visibility.Visible;
                    break;
                case "2":
                    ImageB = Visibility.Visible;
                    break;
                case "3":
                    ImageC = Visibility.Visible;
                    break;
                case "4":
                    ImageD = Visibility.Visible;
                    break;
                case "5":
                    ImageE = Visibility.Visible;
                    break;
                case "6":
                    ImageF = Visibility.Visible;
                    break;
                case "7":
                    ImageG = Visibility.Visible;
                    break;
                case "8":
                    ImageH = Visibility.Visible;
                    break;
                case "9":
                    ImageI = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private ICommand _btnDoCommand;
        public ICommand btnDoCommand
        {
            get
            {
                if (_btnDoCommand == null)
                {
                    _btnDoCommand = new Command.RelayCommand<string>(doCommand);
                }

                return _btnDoCommand;
            }
        }

        private bool _style1 = true;
        public bool style1
        {
            get { return _style1; }
            set
            {
                _style1 = value;
                NotifyPropertyChanged("style1");
            }
        }

        private bool _style2 = true;
        public bool style2
        {
            get { return _style2; }
            set
            {
                _style2 = value;
                NotifyPropertyChanged("style2");
            }
        }

        private bool _style3 = true;
        public bool style3
        {
            get { return _style3; }
            set
            {
                _style3 = value;
                NotifyPropertyChanged("style3");
            }
        }

        private bool _style4 = true;
        public bool style4
        {
            get { return _style4; }
            set
            {
                _style4 = value;
                NotifyPropertyChanged("style4");
            }
        }

        private bool _style5 = true;
        public bool style5
        {
            get { return _style5; }
            set
            {
                _style5 = value;
                NotifyPropertyChanged("style5");
            }
        }

        private bool _style6 = true;
        public bool style6
        {
            get { return _style6; }
            set
            {
                _style6 = value;
                NotifyPropertyChanged("style6");
            }
        }

        private bool _style7 = true;
        public bool style7
        {
            get { return _style7; }
            set
            {
                _style7 = value;
                NotifyPropertyChanged("style7");
            }
        }

        private bool _style8 = true;
        public bool style8
        {
            get { return _style8; }
            set
            {
                _style8 = value;
                NotifyPropertyChanged("style8");
            }
        }

        private bool _style9 = true;
        public bool style9
        {
            get { return _style9; }
            set
            {
                _style9 = value;
                NotifyPropertyChanged("style9");
            }
        }

        private Visibility _ImageA = Visibility.Hidden;
        public Visibility ImageA
        {
            get { return _ImageA; }
            set
            {
                _ImageA = value;
                NotifyPropertyChanged("ImageA");
            }
        }

        private Visibility _ImageB = Visibility.Hidden;
        public Visibility ImageB
        {
            get { return _ImageB; }
            set
            {
                _ImageB = value;
                NotifyPropertyChanged("ImageB");
            }
        }

        private Visibility _ImageC = Visibility.Hidden;
        public Visibility ImageC
        {
            get { return _ImageC; }
            set
            {
                _ImageC = value;
                NotifyPropertyChanged("ImageC");
            }
        }

        private Visibility _ImageD = Visibility.Hidden;
        public Visibility ImageD
        {
            get { return _ImageD; }
            set
            {
                _ImageD = value;
                NotifyPropertyChanged("ImageD");
            }
        }

        private Visibility _ImageE = Visibility.Hidden;
        public Visibility ImageE
        {
            get { return _ImageE; }
            set
            {
                _ImageE = value;
                NotifyPropertyChanged("ImageE");
            }
        }

        private Visibility _ImageF = Visibility.Hidden;
        public Visibility ImageF
        {
            get { return _ImageF; }
            set
            {
                _ImageF = value;
                NotifyPropertyChanged("ImageF");
            }
        }

        private Visibility _ImageG = Visibility.Hidden;
        public Visibility ImageG
        {
            get { return _ImageG; }
            set
            {
                _ImageG = value;
                NotifyPropertyChanged("ImageG");
            }
        }

        private Visibility _ImageH = Visibility.Hidden;
        public Visibility ImageH
        {
            get { return _ImageH; }
            set
            {
                _ImageH = value;
                NotifyPropertyChanged("ImageH");
            }
        }

        private Visibility _ImageI = Visibility.Hidden;
        public Visibility ImageI
        {
            get { return _ImageI; }
            set
            {
                _ImageI = value;
                NotifyPropertyChanged("ImageI");
            }
        }

        private BitmapSource _Image1;
        public BitmapSource Image1
        {
            get { return _Image1; }
            set { _Image1 = value; }
        }

        private BitmapSource _Image2;
        public BitmapSource Image2
        {
            get { return _Image2; }
            set { _Image2 = value; }
        }

        private BitmapSource _Image3;
        public BitmapSource Image3
        {
            get { return _Image3; }
            set { _Image3 = value; }
        }

        private BitmapSource _Image4;
        public BitmapSource Image4
        {
            get { return _Image4; }
            set { _Image4 = value; }
        }

        private BitmapSource _Image5;
        public BitmapSource Image5
        {
            get { return _Image5; }
            set { _Image5 = value; }
        }

        private BitmapSource _Image6;
        public BitmapSource Image6
        {
            get { return _Image6; }
            set { _Image6 = value; }
        }

        private BitmapSource _Image7;
        public BitmapSource Image7
        {
            get { return _Image7; }
            set { _Image7 = value; }
        }

        private BitmapSource _Image8;
        public BitmapSource Image8
        {
            get { return _Image8; }
            set { _Image8 = value; }
        }

        private BitmapSource _Image9;
        public BitmapSource Image9
        {
            get { return _Image9; }
            set { _Image9 = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
