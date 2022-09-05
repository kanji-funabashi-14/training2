using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace MemoryGameA.ViewModels
{
    public class GamePage54ViewModel : INotifyPropertyChanged
    {
        public GamePage54ViewModel()
        {
            Bitmap bmp1 = new Bitmap(@"Resources\MemoryGame_Image\Apple.png");
            IntPtr hbitmap1 = bmp1.GetHbitmap();
            Image1 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap1, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp2 = new Bitmap(@"Resources\MemoryGame_Image\Bear.png");
            IntPtr hbitmap2 = bmp2.GetHbitmap();
            Image2 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap2, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp3 = new Bitmap(@"Resources\MemoryGame_Image\Bread.png");
            IntPtr hbitmap3 = bmp3.GetHbitmap();
            Image3 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap3, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp4 = new Bitmap(@"Resources\MemoryGame_Image\Car.png");
            IntPtr hbitmap4 = bmp4.GetHbitmap();
            Image4 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap4, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp5 = new Bitmap(@"Resources\MemoryGame_Image\Bird.png");
            IntPtr hbitmap5 = bmp5.GetHbitmap();
            Image5 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap5, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp6 = new Bitmap(@"Resources\MemoryGame_Image\Chocolate.png");
            IntPtr hbitmap6 = bmp6.GetHbitmap();
            Image6 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap6, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp7 = new Bitmap(@"Resources\MemoryGame_Image\Bird.png");
            IntPtr hbitmap7 = bmp7.GetHbitmap();
            Image7 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap7, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp8 = new Bitmap(@"Resources\MemoryGame_Image\Cow.png");
            IntPtr hbitmap8 = bmp8.GetHbitmap();
            Image8 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap8, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp9 = new Bitmap(@"Resources\MemoryGame_Image\Banana.png");
            IntPtr hbitmap9 = bmp9.GetHbitmap();
            Image9 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap9, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp10 = new Bitmap(@"Resources\MemoryGame_Image\Banana.png");
            IntPtr hbitmap10 = bmp10.GetHbitmap();
            Image10 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap10, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp11 = new Bitmap(@"Resources\MemoryGame_Image\ChristmasTree.png");
            IntPtr hbitmap11 = bmp11.GetHbitmap();
            Image11 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap11, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp12 = new Bitmap(@"Resources\MemoryGame_Image\Bear.png");
            IntPtr hbitmap12 = bmp12.GetHbitmap();
            Image12 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap12, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp13 = new Bitmap(@"Resources\MemoryGame_Image\Butterfly.png");
            IntPtr hbitmap13 = bmp13.GetHbitmap();
            Image13 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap13, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp14 = new Bitmap(@"Resources\MemoryGame_Image\Apple.png");
            IntPtr hbitmap14 = bmp14.GetHbitmap();
            Image14 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap14, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp15 = new Bitmap(@"Resources\MemoryGame_Image\Butterfly.png");
            IntPtr hbitmap15 = bmp15.GetHbitmap();
            Image15 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap15, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp16 = new Bitmap(@"Resources\MemoryGame_Image\Cow.png");
            IntPtr hbitmap16 = bmp16.GetHbitmap();
            Image16 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap16, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp17 = new Bitmap(@"Resources\MemoryGame_Image\Car.png");
            IntPtr hbitmap17 = bmp17.GetHbitmap();
            Image17 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap17, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp18 = new Bitmap(@"Resources\MemoryGame_Image\ChristmasTree.png");
            IntPtr hbitmap18 = bmp18.GetHbitmap();
            Image18 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap18, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp19 = new Bitmap(@"Resources\MemoryGame_Image\Bread.png");
            IntPtr hbitmap19 = bmp19.GetHbitmap();
            Image19 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap19, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp20 = new Bitmap(@"Resources\MemoryGame_Image\Chocolate.png");
            IntPtr hbitmap20 = bmp20.GetHbitmap();
            Image20 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap20, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
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
                case "10":
                    ImageJ = Visibility.Visible;
                    break;
                case "11":
                    ImageK = Visibility.Visible;
                    break;
                case "12":
                    ImageL = Visibility.Visible;
                    break;
                case "13":
                    ImageM = Visibility.Visible;
                    break;
                case "14":
                    ImageN = Visibility.Visible;
                    break;
                case "15":
                    ImageO = Visibility.Visible;
                    break;
                case "16":
                    ImageP = Visibility.Visible;
                    break;
                case "17":
                    ImageQ = Visibility.Visible;
                    break;
                case "18":
                    ImageR = Visibility.Visible;
                    break;
                case "19":
                    ImageS = Visibility.Visible;
                    break;
                case "20":
                    ImageT = Visibility.Visible;
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

        private bool _style10 = true;
        public bool style10
        {
            get { return _style10; }
            set
            {
                _style10 = value;
                NotifyPropertyChanged("style10");
            }
        }

        private bool _style11 = true;
        public bool style11
        {
            get { return _style11; }
            set
            {
                _style11 = value;
                NotifyPropertyChanged("style11");
            }
        }

        private bool _style12 = true;
        public bool style12
        {
            get { return _style12; }
            set
            {
                _style12 = value;
                NotifyPropertyChanged("style12");
            }
        }

        private bool _style13 = true;
        public bool style13
        {
            get { return _style13; }
            set
            {
                _style13 = value;
                NotifyPropertyChanged("style13");
            }
        }

        private bool _style14 = true;
        public bool style14
        {
            get { return _style14; }
            set
            {
                _style14 = value;
                NotifyPropertyChanged("style14");
            }
        }

        private bool _style15 = true;
        public bool style15
        {
            get { return _style15; }
            set
            {
                _style15 = value;
                NotifyPropertyChanged("style15");
            }
        }

        private bool _style16 = true;
        public bool style16
        {
            get { return _style16; }
            set
            {
                _style16 = value;
                NotifyPropertyChanged("style16");
            }
        }

        private bool _style17 = true;
        public bool style17
        {
            get { return _style17; }
            set
            {
                _style17 = value;
                NotifyPropertyChanged("style17");
            }
        }

        private bool _style18 = true;
        public bool style18
        {
            get { return _style18; }
            set
            {
                _style18 = value;
                NotifyPropertyChanged("style18");
            }
        }

        private bool _style19 = true;
        public bool style19
        {
            get { return _style19; }
            set
            {
                _style19 = value;
                NotifyPropertyChanged("style19");
            }
        }

        private bool _style20 = true;
        public bool style20
        {
            get { return _style20; }
            set
            {
                _style20 = value;
                NotifyPropertyChanged("style20");
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

        private Visibility _ImageJ = Visibility.Hidden;
        public Visibility ImageJ
        {
            get { return _ImageJ; }
            set
            {
                _ImageJ = value;
                NotifyPropertyChanged("ImageJ");
            }
        }

        private Visibility _ImageK = Visibility.Hidden;
        public Visibility ImageK
        {
            get { return _ImageK; }
            set
            {
                _ImageK = value;
                NotifyPropertyChanged("ImageK");
            }
        }

        private Visibility _ImageL = Visibility.Hidden;
        public Visibility ImageL
        {
            get { return _ImageL; }
            set
            {
                _ImageL = value;
                NotifyPropertyChanged("ImageL");
            }
        }

        private Visibility _ImageM = Visibility.Hidden;
        public Visibility ImageM
        {
            get { return _ImageM; }
            set
            {
                _ImageM = value;
                NotifyPropertyChanged("ImageM");
            }
        }

        private Visibility _ImageN = Visibility.Hidden;
        public Visibility ImageN
        {
            get { return _ImageN; }
            set
            {
                _ImageN = value;
                NotifyPropertyChanged("ImageN");
            }
        }

        private Visibility _ImageO = Visibility.Hidden;
        public Visibility ImageO
        {
            get { return _ImageO; }
            set
            {
                _ImageO = value;
                NotifyPropertyChanged("ImageO");
            }
        }

        private Visibility _ImageP = Visibility.Hidden;
        public Visibility ImageP
        {
            get { return _ImageP; }
            set
            {
                _ImageP = value;
                NotifyPropertyChanged("ImageP");
            }
        }

        private Visibility _ImageQ = Visibility.Hidden;
        public Visibility ImageQ
        {
            get { return _ImageQ; }
            set
            {
                _ImageQ = value;
                NotifyPropertyChanged("ImageQ");
            }
        }

        private Visibility _ImageR = Visibility.Hidden;
        public Visibility ImageR
        {
            get { return _ImageR; }
            set
            {
                _ImageR = value;
                NotifyPropertyChanged("ImageR");
            }
        }

        private Visibility _ImageS = Visibility.Hidden;
        public Visibility ImageS
        {
            get { return _ImageS; }
            set
            {
                _ImageS = value;
                NotifyPropertyChanged("ImageS");
            }
        }

        private Visibility _ImageT = Visibility.Hidden;
        public Visibility ImageT
        {
            get { return _ImageT; }
            set
            {
                _ImageT = value;
                NotifyPropertyChanged("ImageT");
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

        private BitmapSource _Image10;
        public BitmapSource Image10
        {
            get { return _Image10; }
            set { _Image10 = value; }
        }

        private BitmapSource _Image11;
        public BitmapSource Image11
        {
            get { return _Image11; }
            set { _Image11 = value; }
        }

        private BitmapSource _Image12;
        public BitmapSource Image12
        {
            get { return _Image12; }
            set { _Image12 = value; }
        }

        private BitmapSource _Image13;
        public BitmapSource Image13
        {
            get { return _Image13; }
            set { _Image13 = value; }
        }

        private BitmapSource _Image14;
        public BitmapSource Image14
        {
            get { return _Image14; }
            set { _Image14 = value; }
        }

        private BitmapSource _Image15;
        public BitmapSource Image15
        {
            get { return _Image15; }
            set { _Image15 = value; }
        }

        private BitmapSource _Image16;
        public BitmapSource Image16
        {
            get { return _Image16; }
            set { _Image16 = value; }
        }

        private BitmapSource _Image17;
        public BitmapSource Image17
        {
            get { return _Image17; }
            set { _Image17 = value; }
        }

        private BitmapSource _Image18;
        public BitmapSource Image18
        {
            get { return _Image18; }
            set { _Image18 = value; }
        }

        private BitmapSource _Image19;
        public BitmapSource Image19
        {
            get { return _Image19; }
            set { _Image19 = value; }
        }

        private BitmapSource _Image20;
        public BitmapSource Image20
        {
            get { return _Image20; }
            set { _Image20 = value; }
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
