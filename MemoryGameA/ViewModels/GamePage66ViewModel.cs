using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace MemoryGameA
{
    public class GamePage66ViewModel : INotifyPropertyChanged
    {
        public GamePage66ViewModel()
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

            Bitmap bmp9 = new Bitmap(@"Resources\MemoryGame_Image\Egg.png");
            IntPtr hbitmap9 = bmp9.GetHbitmap();
            Image9 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap9, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp10 = new Bitmap(@"Resources\MemoryGame_Image\Fish.png");
            IntPtr hbitmap10 = bmp10.GetHbitmap();
            Image10 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap10, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp11 = new Bitmap(@"Resources\MemoryGame_Image\Frog.png");
            IntPtr hbitmap11 = bmp11.GetHbitmap();
            Image11 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap11, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp12 = new Bitmap(@"Resources\MemoryGame_Image\Heart.png");
            IntPtr hbitmap12 = bmp12.GetHbitmap();
            Image12 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap12, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp13 = new Bitmap(@"Resources\MemoryGame_Image\Star.png");
            IntPtr hbitmap13 = bmp13.GetHbitmap();
            Image13 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap13, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp14 = new Bitmap(@"Resources\MemoryGame_Image\Frog.png");
            IntPtr hbitmap14 = bmp14.GetHbitmap();
            Image14 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap14, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp15 = new Bitmap(@"Resources\MemoryGame_Image\Sun.png");
            IntPtr hbitmap15 = bmp15.GetHbitmap();
            Image15 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap15, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp16 = new Bitmap(@"Resources\MemoryGame_Image\Butterfly.png");
            IntPtr hbitmap16 = bmp16.GetHbitmap();
            Image16 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap16, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp17 = new Bitmap(@"Resources\MemoryGame_Image\Rainbow.png");
            IntPtr hbitmap17 = bmp17.GetHbitmap();
            Image17 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap17, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp18 = new Bitmap(@"Resources\MemoryGame_Image\ChristmasTree.png");
            IntPtr hbitmap18 = bmp18.GetHbitmap();
            Image18 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap18, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp19 = new Bitmap(@"Resources\MemoryGame_Image\Apple.png");
            IntPtr hbitmap19 = bmp19.GetHbitmap();
            Image19 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap19, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp20 = new Bitmap(@"Resources\MemoryGame_Image\Banana.png");
            IntPtr hbitmap20 = bmp20.GetHbitmap();
            Image20 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap20, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp21 = new Bitmap(@"Resources\MemoryGame_Image\Banana.png");
            IntPtr hbitmap21 = bmp21.GetHbitmap();
            Image21 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap21, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp22 = new Bitmap(@"Resources\MemoryGame_Image\Rainbow.png");
            IntPtr hbitmap22 = bmp22.GetHbitmap();
            Image22 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap22, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp23 = new Bitmap(@"Resources\MemoryGame_Image\Bear.png");
            IntPtr hbitmap23 = bmp23.GetHbitmap();
            Image23 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap23, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp24 = new Bitmap(@"Resources\MemoryGame_Image\Bread.png");
            IntPtr hbitmap24 = bmp24.GetHbitmap();
            Image24 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap24, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp25 = new Bitmap(@"Resources\MemoryGame_Image\Heart.png");
            IntPtr hbitmap25 = bmp25.GetHbitmap();
            Image25 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap25, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp26 = new Bitmap(@"Resources\MemoryGame_Image\Butterfly.png");
            IntPtr hbitmap26 = bmp26.GetHbitmap();
            Image26 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap26, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp27 = new Bitmap(@"Resources\MemoryGame_Image\Car.png");
            IntPtr hbitmap27 = bmp27.GetHbitmap();
            Image27 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap27, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp28 = new Bitmap(@"Resources\MemoryGame_Image\Flower.png");
            IntPtr hbitmap28 = bmp28.GetHbitmap();
            Image28 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap28, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp29 = new Bitmap(@"Resources\MemoryGame_Image\Flower.png");
            IntPtr hbitmap29 = bmp29.GetHbitmap();
            Image29 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap29, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp30 = new Bitmap(@"Resources\MemoryGame_Image\Chocolate.png");
            IntPtr hbitmap30 = bmp30.GetHbitmap();
            Image30 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap30, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp31 = new Bitmap(@"Resources\MemoryGame_Image\Cow.png");
            IntPtr hbitmap31 = bmp31.GetHbitmap();
            Image31 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap31, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp32 = new Bitmap(@"Resources\MemoryGame_Image\Egg.png");
            IntPtr hbitmap32 = bmp32.GetHbitmap();
            Image32 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap32, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp33 = new Bitmap(@"Resources\MemoryGame_Image\Fish.png");
            IntPtr hbitmap33 = bmp33.GetHbitmap();
            Image33 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap33, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp34 = new Bitmap(@"Resources\MemoryGame_Image\Star.png");
            IntPtr hbitmap34 = bmp34.GetHbitmap();
            Image34 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap34, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp35 = new Bitmap(@"Resources\MemoryGame_Image\Sun.png");
            IntPtr hbitmap35 = bmp35.GetHbitmap();
            Image35 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap35, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            Bitmap bmp36 = new Bitmap(@"Resources\MemoryGame_Image\ChristmasTree.png");
            IntPtr hbitmap36 = bmp36.GetHbitmap();
            Image36 = Imaging.CreateBitmapSourceFromHBitmap(hbitmap36, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }
        
        int count = 0;

        BitmapSource? Card1 = null;
        BitmapSource? Card2 = null;
        
        public void DoCommand(string p)
        { 
            switch (p)
            {
                case "1":                   
                    if (ImageA == Visibility.Hidden)
                    {
                        ImageA = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image1;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image1;
                        }
                    }             
                    break;
                case "2":
                    if (ImageB == Visibility.Hidden)
                    {
                        ImageB = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image2;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image2;
                        }
                    }                   
                    break ;
                case "3":
                    if (ImageC == Visibility.Hidden)
                    {
                        ImageC = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image3;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image3;
                        }
                    }
                    break;
                case "4":
                    if (ImageD == Visibility.Hidden)
                    {
                        ImageD = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image4;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image4;
                        }
                    }
                    break;
                case "5":
                    if (ImageE == Visibility.Hidden)
                    {
                        ImageE = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image5;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image5;
                        }
                    }
                    break;
                case "6":
                    if (ImageF == Visibility.Hidden)
                    {
                        ImageF = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image6;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image6;
                        }
                    }
                    break;
                case "7":
                    if (ImageG == Visibility.Hidden)
                    {
                        ImageG = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image7;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image7;
                        }
                    }
                    break;
                case "8":
                    if (ImageH == Visibility.Hidden)
                    {
                        ImageH = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image8;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image8;
                        }
                    }
                    break;
                case "9":
                    if (ImageI == Visibility.Hidden)
                    {
                        ImageI = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image9;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image9;
                        }
                    }
                    break;
                case "10":
                    if (ImageJ == Visibility.Hidden)
                    {
                        ImageJ = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image10;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image10;
                        }
                    }
                    break;
                case "11":
                    if (ImageK == Visibility.Hidden)
                    {
                        ImageK = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image11;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image11;
                        }
                    }
                    break;
                case "12":
                    if (ImageL == Visibility.Hidden)
                    {
                        ImageL = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image12;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image12;
                        }
                    }
                    break;
                case "13":
                    if (ImageM == Visibility.Hidden)
                    {
                        ImageM = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image13;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image13;
                        }
                    }
                    break;
                case "14":
                    if (ImageN == Visibility.Hidden)
                    {
                        ImageN = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image14;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image14;
                        }
                    }
                    break;
                case "15":
                    if (ImageO == Visibility.Hidden)
                    {
                        ImageO = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image15;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image15;
                        }
                    }
                    break;
                case "16":
                    if (ImageP == Visibility.Hidden)
                    {
                        ImageP = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image16;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image16;
                        }
                    }
                    break;
                case "17":
                    if (ImageQ == Visibility.Hidden)
                    {
                        ImageQ = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image17;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image17;
                        }
                    }
                    break;
                case "18":
                    if (ImageR == Visibility.Hidden)
                    {
                        ImageR = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image18;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image18;
                        }
                    }
                    break;
                case "19":
                    if (ImageS == Visibility.Hidden)
                    {
                        ImageS = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image19;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image19;
                        }
                    }
                    break;
                case "20":
                    if (ImageT == Visibility.Hidden)
                    {
                        ImageT = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image20;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image20;
                        }
                    }
                    break;
                case "21":
                    if (ImageU == Visibility.Hidden)
                    {
                        ImageU = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image21;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image21;
                        }
                    }
                    break;
                case "22":
                    if (ImageV == Visibility.Hidden)
                    {
                        ImageV = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image22;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image22;
                        }
                    }
                    break;
                case "23":
                    if (ImageW == Visibility.Hidden)
                    {
                        ImageW = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image23;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image23;
                        }
                    }
                    break;
                case "24":
                    if (ImageX == Visibility.Hidden)
                    {
                        ImageX = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image24;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image24;
                        }
                    }
                    break;
                case "25":
                    if (ImageY == Visibility.Hidden)
                    {
                        ImageY = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image25;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image25;
                        }
                    }
                    break;
                case "26":
                    if (ImageZ == Visibility.Hidden)
                    {
                        ImageZ = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image26;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image26;
                        }
                    }
                    break;
                case "27":
                    if (ImageAA == Visibility.Hidden)
                    {
                        ImageAA = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image27;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image27;
                        }
                    }
                    break;
                case "28":
                    if (ImageBB == Visibility.Hidden)
                    {
                        ImageBB = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image28;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image28;
                        }
                    }
                    break;
                case "29":
                    if (ImageCC == Visibility.Hidden)
                    {
                        ImageCC = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image29;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image29;
                        }
                    }
                    break;
                case "30":
                    if (ImageDD == Visibility.Hidden)
                    {
                        ImageDD = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image30;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image30;
                        }
                    }
                    break;
                case "31":
                    if (ImageEE == Visibility.Hidden)
                    {
                        ImageEE = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image31;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image31;
                        }
                    }
                    break;
                case "32":
                    if (ImageFF == Visibility.Hidden)
                    {
                        ImageFF = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image32;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image32;
                        }
                    }
                    break;
                case "33":
                    if (ImageGG == Visibility.Hidden)
                    {
                        ImageGG = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image33;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image33;
                        }
                    }
                    break;
                case "34":
                    if (ImageHH == Visibility.Hidden)
                    {
                        ImageHH = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image34;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image34;
                        }
                    }
                    break;
                case "35":
                    if (ImageII == Visibility.Hidden)
                    {
                        ImageII = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image35;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image35;
                        }
                    }       
                    break;
                case "36":
                    if (ImageJJ == Visibility.Hidden)
                    {
                        ImageJJ = Visibility.Visible;
                        count += 1;

                        if (count == 1)
                        {
                            Card1 = Image36;
                        }
                        else if (count == 2)
                        {
                            Card2 = Image36;
                        }
                    }
                    break;
                default:
                    break;
                
            }

            if (count == 2)
            {
                if (Card1 == Image1)
                {           
                    if(Card2 == Image2)
                    {                
                        ImageA = Visibility.Hidden;
                        ImageB = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageA = Visibility.Hidden;
                        ImageC = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageA = Visibility.Hidden;
                        ImageD = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageA = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageA = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageA = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageA = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageA = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageA = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageA = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageA = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageA = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageA = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageA = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageA = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageA = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageA = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        style1 = false;
                        style19 = false;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageA = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageA = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageA = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageA = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageA = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageA = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageA = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageA = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageA = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageA = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageA = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageA = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageA = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageA = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageA = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageA = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageA = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image2)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageB = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageB = Visibility.Hidden;
                        ImageC = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageB = Visibility.Hidden;
                        ImageD = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageB = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageB = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageB = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageB = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageB = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageB = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageB = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageB = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageB = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageB = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageB = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageB = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageB = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageB = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageB = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageB = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageB = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageB = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        style2 = false;
                        style23 = false;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageB = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageB = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageB = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageB = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageB = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageB = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageB = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageB = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageB = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageB = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageB = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageB = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageB = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image3)
                {
                    if (Card2 == Image1)
                    {
                        ImageC = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageC = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageC = Visibility.Hidden;
                        ImageD = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageC = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageC = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageC = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageC = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageC = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageC = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageC = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageC = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageC = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageC = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageC = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageC = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageC = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageC = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageC = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageC = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageC = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageC = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageC = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        style3 = false;
                        style24 = false;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageC = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageC = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageC = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageC = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageC = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageC = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageC = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageC = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageC = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageC = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageC = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageC = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image4)
                {
                    if (Card2 == Image1)
                    {
                        ImageD = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageD = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageD = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageD = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageD = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageD = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageD = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageD = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageD = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageD = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageD = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageD = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageD = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageD = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageD = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageD = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageD = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageD = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageD = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageD = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageD = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageD = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageD = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageD = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageD = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        style4 = false;
                        style27 = false;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageD = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageD = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageD = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageD = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageD = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageD = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageD = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageD = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageD = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image5)
                {
                    if (Card2 == Image1)
                    {
                        ImageE = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageE = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageE = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        style5 = false;
                        style7 = false;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageE = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageE = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageE = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageE = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageE = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageE = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageE = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageE = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageE = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageE = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageE = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageE = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageE = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageE = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageE = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageE = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageE = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageE = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageE = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageE = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageE = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageE = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageE = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageE = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageE = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageE = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageE = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageE = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageE = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image6)
                {
                    if (Card2 == Image1)
                    {
                        ImageF = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageF = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageF = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageF = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageF = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageF = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageF = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageF = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageF = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageF = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageF = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageF = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageF = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageF = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageF = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageF = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageF = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageF = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageF = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageF = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageF = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageF = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageF = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageF = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        style6 = false;
                        style30 = false;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageF = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageF = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageF = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageF = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageF = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageF = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image7)
                {
                    if (Card2 == Image1)
                    {
                        ImageG = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        style5 = false;
                        style7 = false;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageG = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageG = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageG = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageG = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageG = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageG = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageG = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageG = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageG = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageG = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageG = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageG = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageG = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageG = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageG = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageG = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageG = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageG = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageG = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageG = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageG = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageG = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageG = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageG = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageG = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageG = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageG = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageG = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageG = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image8)
                {
                    if (Card2 == Image1)
                    {
                        ImageH = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageH = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageH = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageH = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageH = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageH = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageH = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageH = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageH = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageH = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageH = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageH = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageH = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageH = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageH = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageH = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageH = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageH = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageH = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageH = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageH = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageH = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageH = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        style8 = false;
                        style31 = false;                       
                    }
                    else if (Card2 == Image32)
                    {
                        ImageH = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageH = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageH = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageH = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageH = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image9)
                {
                    if (Card2 == Image1)
                    {
                        ImageI = Visibility.Hidden;
                        ImageA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageI = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageI = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageI = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageI = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageI = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageI = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageI = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageI = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageI = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageI = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageI = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageI = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageI = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageI = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageI = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageI = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageI = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageI = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageI = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageI = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageI = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageI = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageI = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        style9 = false;
                        style32 = false;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageI = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageI = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageI = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageI = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image10)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        style10 = false;
                        style33 = false;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image11)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageK = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageK = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageK = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        style11 = false;
                        style14 = false;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageK = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageK = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageK = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageK = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageK = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageK = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageK = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageK = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageK = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageK = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageK = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageK = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageK = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageK = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageK = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageK = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageK = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageK = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageK = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageK = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageK = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageK = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image12)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageL = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageL = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageL = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageL = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageL = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageL = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageL = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageL = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageL = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageL = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageL = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageL = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageL = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        style12 = false;
                        style25 = false;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageL = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageL = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageL = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageL = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageL = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageL = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageL = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageL = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageL = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageL = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageL = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image13)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageM = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageM = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageM = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageM = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageM = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageM = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageM = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageM = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageM = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageM = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageM = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageM = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageM = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageM = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageM = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageM = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageM = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageM = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageM = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageM = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageM = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        style13 = false;
                        style34 = false;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageM = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageM = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image14)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        style11 = false;
                        style14 = false;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageN = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageN = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageN = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageN = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageN = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageN = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageN = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageN = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageN = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageN = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageN = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageN = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageN = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageN = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageN = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageN = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageN = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageN = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageN = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageN = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageN = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageN = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageN = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image15)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageO = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageO = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageO = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageO = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageO = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageO = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageO = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageO = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageO = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageO = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageO = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageO = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageO = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageO = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageO = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageO = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageO = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageO = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageO = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageO = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        style15 = false;
                        style35 = false;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageO = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image16)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageP = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageP = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageP = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageP = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageP = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageP = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageP = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageP = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageP = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageP = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        style16 = false;
                        style26 = false;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageP = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageP = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageP = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageP = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageP = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageP = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageP = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageP = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageP = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageP = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image17)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageQ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        style17 = false;
                        style22 = false;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image18)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageR = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageR = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageR = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageR = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageR = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageR = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageR = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageR = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageR = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageR = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageR = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageR = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageR = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageR = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageR = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageR = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageR = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageR = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        style18 = false;
                        style36 = false;
                    }
                    count = 0;
                }

                if (Card1 == Image19)
                {
                    if (Card2 == Image1)
                    {
                        style11 = false;
                        style19 = false;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageS = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageS = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageS = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageS = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageS = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageS = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageS = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageS = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageS = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageS = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageS = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageS = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageS = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageS = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageS = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageS = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageS = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageS = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image20)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageT = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        style20 = false;
                        style21 = false;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageT = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageT = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageT = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageT = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageT = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageT = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageT = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageT = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageT = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageT = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageT = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageT = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageT = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageT = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageT = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image21)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageU = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        style20 = false;
                        style21 = false;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageU = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageU = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageU = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageU = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageU = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageU = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageU = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageU = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageU = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageU = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageU = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageU = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageU = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageU = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageU = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image22)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        style17 = false;
                        style22 = false;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageV = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageV = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageV = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageV = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageV = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageV = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageV = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageV = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageV = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageV = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageV = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageV = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageV = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageV = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageV = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image23)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        style2 = false;
                        style23 = false;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageW = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageW = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageW = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageW = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageW = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageW = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageW = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageW = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageW = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageW = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageW = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageW = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageW = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageW = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image24)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        style3 = false;
                        style24 = false;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageX = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageX = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageX = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageX = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageX = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageX = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageX = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageX = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageX = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageX = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageX = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageX = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageX = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image25)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        style12 = false;
                        style25 = false;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageY = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageY = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageY = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageY = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageY = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageY = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageY = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageY = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageY = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageY = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageY = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageY = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image26)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        style16 = false;
                        style26 = false;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageZ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image27)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        style4 = false;
                        style27 = false;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageAA = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image28)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageBB = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        style28 = false;
                        style29 = false;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image29)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageCC = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        style28 = false;
                        style29 = false;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image30)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        style6 = false;
                        style30 = false;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageDD = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image31)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        style8 = false;
                        style31 = false;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageEE = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image32)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        style9 = false;
                        style32 = false;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageFF = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image33)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        style10 = false;
                        style33 = false;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageGG = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageGG = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageGG = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageGG = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image34)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        style13 = false;
                        style34 = false;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageO = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageGG = Visibility.Hidden;
                        ImageHH = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageHH = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageHH = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image35)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        style15 = false;
                        style35 = false;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        ImageR = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageGG = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageHH = Visibility.Hidden;
                        ImageII = Visibility.Hidden;
                    }
                    else if (Card2 == Image36)
                    {
                        ImageII = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                if (Card1 == Image36)
                {
                    if (Card2 == Image1)
                    {
                        ImageA = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image2)
                    {
                        ImageB = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image3)
                    {
                        ImageC = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image4)
                    {
                        ImageD = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image5)
                    {
                        ImageE = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image6)
                    {
                        ImageF = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image7)
                    {
                        ImageG = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image8)
                    {
                        ImageH = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image9)
                    {
                        ImageI = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image10)
                    {
                        ImageJ = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image11)
                    {
                        ImageK = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image12)
                    {
                        ImageL = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image13)
                    {
                        ImageM = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image14)
                    {
                        ImageN = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image15)
                    {
                        ImageR = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image16)
                    {
                        ImageP = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image17)
                    {
                        ImageQ = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image18)
                    {
                        style18 = false;
                        style36 = false;
                    }
                    else if (Card2 == Image19)
                    {
                        ImageS = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image20)
                    {
                        ImageT = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image21)
                    {
                        ImageU = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image22)
                    {
                        ImageV = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image23)
                    {
                        ImageW = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image24)
                    {
                        ImageX = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image25)
                    {
                        ImageY = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image26)
                    {
                        ImageZ = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image27)
                    {
                        ImageAA = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image28)
                    {
                        ImageBB = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image29)
                    {
                        ImageCC = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image30)
                    {
                        ImageDD = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image31)
                    {
                        ImageEE = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image32)
                    {
                        ImageFF = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image33)
                    {
                        ImageGG = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image34)
                    {
                        ImageHH = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    else if (Card2 == Image35)
                    {
                        ImageII = Visibility.Hidden;
                        ImageJJ = Visibility.Hidden;
                    }
                    count = 0;
                }

                Card1 = null;
                Card2 = null;                
            }           
        }

        private ICommand _btnDoCommand;
        public ICommand btnDoCommand
        {
            get
            {
                if (_btnDoCommand == null)
                {
                    _btnDoCommand = new Command.RelayCommand<string>(DoCommand);
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

        private bool _style21 = true;
        public bool style21
        {
            get { return _style21; }
            set
            {
                _style21 = value;
                NotifyPropertyChanged("style21");
            }
        }

        private bool _style22 = true;
        public bool style22
        {
            get { return _style22; }
            set
            {
                _style22 = value;
                NotifyPropertyChanged("style22");
            }
        }

        private bool _style23 = true;
        public bool style23
        {
            get { return _style23; }
            set
            {
                _style23 = value;
                NotifyPropertyChanged("style23");
            }
        }

        private bool _style24 = true;
        public bool style24
        {
            get { return _style24; }
            set
            {
                _style24 = value;
                NotifyPropertyChanged("style24");
            }
        }

        private bool _style25 = true;
        public bool style25
        {
            get { return _style25; }
            set
            {
                _style25 = value;
                NotifyPropertyChanged("style25");
            }
        }

        private bool _style26 = true;
        public bool style26
        {
            get { return _style26; }
            set
            {
                _style26 = value;
                NotifyPropertyChanged("style26");
            }
        }

        private bool _style27 = true;
        public bool style27
        {
            get { return _style27; }
            set
            {
                _style27 = value;
                NotifyPropertyChanged("style27");
            }
        }

        private bool _style28 = true;
        public bool style28
        {
            get { return _style28; }
            set
            {
                _style28 = value;
                NotifyPropertyChanged("style28");
            }
        }

        private bool _style29 = true;
        public bool style29
        {
            get { return _style29; }
            set
            {
                _style29 = value;
                NotifyPropertyChanged("style29");
            }
        }

        private bool _style30 = true;
        public bool style30
        {
            get { return _style30; }
            set
            {
                _style30 = value;
                NotifyPropertyChanged("style30");
            }
        }

        private bool _style31 = true;
        public bool style31
        {
            get { return _style31; }
            set
            {
                _style31 = value;
                NotifyPropertyChanged("style31");
            }
        }

        private bool _style32 = true;
        public bool style32
        {
            get { return _style32; }
            set
            {
                _style32 = value;
                NotifyPropertyChanged("style32");
            }
        }

        private bool _style33 = true;
        public bool style33
        {
            get { return _style33; }
            set
            {
                _style33 = value;
                NotifyPropertyChanged("style33");
            }
        }

        private bool _style34 = true;
        public bool style34
        {
            get { return _style34; }
            set
            {
                _style34 = value;
                NotifyPropertyChanged("style34");
            }
        }

        private bool _style35 = true;
        public bool style35
        {
            get { return _style35; }
            set
            {
                _style35 = value;
                NotifyPropertyChanged("style35");
            }
        }

        private bool _style36 = true;
        public bool style36
        {
            get { return _style36; }
            set
            {
                _style36 = value;
                NotifyPropertyChanged("style36");
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

        private Visibility _ImageU = Visibility.Hidden;
        public Visibility ImageU
        {
            get { return _ImageU; }
            set
            {
                _ImageU = value;
                NotifyPropertyChanged("ImageU");
            }
        }

        private Visibility _ImageV = Visibility.Hidden;
        public Visibility ImageV
        {
            get { return _ImageV; }
            set
            {
                _ImageV = value;
                NotifyPropertyChanged("ImageV");
            }
        }

        private Visibility _ImageW = Visibility.Hidden;
        public Visibility ImageW
        {
            get { return _ImageW; }
            set
            {
                _ImageW = value;
                NotifyPropertyChanged("ImageW");
            }
        }

        private Visibility _ImageX = Visibility.Hidden;
        public Visibility ImageX
        {
            get { return _ImageX; }
            set
            {
                _ImageX = value;
                NotifyPropertyChanged("ImageX");
            }
        }

        private Visibility _ImageY = Visibility.Hidden;
        public Visibility ImageY
        {
            get { return _ImageY; }
            set
            {
                _ImageY = value;
                NotifyPropertyChanged("ImageY");
            }
        }

        private Visibility _ImageZ = Visibility.Hidden;
        public Visibility ImageZ
        {
            get { return _ImageZ; }
            set
            {
                _ImageZ = value;
                NotifyPropertyChanged("ImageZ");
            }
        }

        private Visibility _ImageAA = Visibility.Hidden;
        public Visibility ImageAA
        {
            get { return _ImageAA; }
            set
            {
                _ImageAA = value;
                NotifyPropertyChanged("ImageAA");
            }
        }

        private Visibility _ImageBB = Visibility.Hidden;
        public Visibility ImageBB
        {
            get { return _ImageBB; }
            set
            {
                _ImageBB = value;
                NotifyPropertyChanged("ImageBB");
            }
        }

        private Visibility _ImageCC = Visibility.Hidden;
        public Visibility ImageCC
        {
            get { return _ImageCC; }
            set
            {
                _ImageCC = value;
                NotifyPropertyChanged("ImageCC");
            }
        }

        private Visibility _ImageDD = Visibility.Hidden;
        public Visibility ImageDD
        {
            get { return _ImageDD; }
            set
            {
                _ImageDD = value;
                NotifyPropertyChanged("ImageDD");
            }
        }

        private Visibility _ImageEE = Visibility.Hidden;
        public Visibility ImageEE
        {
            get { return _ImageEE; }
            set
            {
                _ImageEE = value;
                NotifyPropertyChanged("ImageEE");
            }
        }

        private Visibility _ImageFF = Visibility.Hidden;
        public Visibility ImageFF
        {
            get { return _ImageFF; }
            set
            {
                _ImageFF = value;
                NotifyPropertyChanged("ImageFF");
            }
        }

        private Visibility _ImageGG = Visibility.Hidden;
        public Visibility ImageGG
        {
            get { return _ImageGG; }
            set
            {
                _ImageGG = value;
                NotifyPropertyChanged("ImageGG");
            }
        }

        private Visibility _ImageHH = Visibility.Hidden;
        public Visibility ImageHH
        {
            get { return _ImageHH; }
            set
            {
                _ImageHH = value;
                NotifyPropertyChanged("ImageHH");
            }
        }

        private Visibility _ImageII = Visibility.Hidden;
        public Visibility ImageII
        {
            get { return _ImageII; }
            set
            {
                _ImageII = value;
                NotifyPropertyChanged("ImageII");
            }
        }

        private Visibility _ImageJJ = Visibility.Hidden;
        public Visibility ImageJJ
        {
            get { return _ImageJJ; }
            set
            {
                _ImageJJ = value;
                NotifyPropertyChanged("ImageJJ");
            }
        }

        private BitmapSource _Image1;
        public BitmapSource Image1
        {
            get { return _Image1; }
            set
            {
                _Image1 = value;
            }
        }

        private BitmapSource _Image2;
        public BitmapSource Image2
        {
            get { return _Image2; }
            set 
            { 
                _Image2 = value;
            }
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

        private BitmapSource _Image21;
        public BitmapSource Image21
        {
            get { return _Image21; }
            set { _Image21 = value; }
        }

        private BitmapSource _Image22;
        public BitmapSource Image22
        {
            get { return _Image22; }
            set { _Image22 = value; }
        }

        private BitmapSource _Image23;
        public BitmapSource Image23
        {
            get { return _Image23; }
            set { _Image23 = value; }
        }

        private BitmapSource _Image24;
        public BitmapSource Image24
        {
            get { return _Image24; }
            set { _Image24 = value; }
        }

        private BitmapSource _Image25;
        public BitmapSource Image25
        {
            get { return _Image25; }
            set { _Image25 = value; }
        }

        private BitmapSource _Image26;
        public BitmapSource Image26
        {
            get { return _Image26; }
            set { _Image26 = value; }
        }

        private BitmapSource _Image27;
        public BitmapSource Image27
        {
            get { return _Image27; }
            set { _Image27 = value; }
        }

        private BitmapSource _Image28;
        public BitmapSource Image28
        {
            get { return _Image28; }
            set { _Image28 = value; }
        }

        private BitmapSource _Image29;
        public BitmapSource Image29
        {
            get { return _Image29; }
            set { _Image29 = value; }
        }

        private BitmapSource _Image30;
        public BitmapSource Image30
        {
            get { return _Image30; }
            set { _Image30 = value; }
        }

        private BitmapSource _Image31;
        public BitmapSource Image31
        {
            get { return _Image31; }
            set { _Image31 = value; }
        }

        private BitmapSource _Image32;
        public BitmapSource Image32
        {
            get { return _Image32; }
            set { _Image32 = value; }
        }

        private BitmapSource _Image33;
        public BitmapSource Image33
        {
            get { return _Image33; }
            set { _Image33 = value; }
        }

        private BitmapSource _Image34;
        public BitmapSource Image34
        {
            get { return _Image34; }
            set { _Image34 = value; }
        }

        private BitmapSource _Image35;
        public BitmapSource Image35
        {
            get { return _Image35; }
            set { _Image35 = value; }
        }

        private BitmapSource _Image36;
        public BitmapSource Image36
        {
            get { return _Image36; }
            set { _Image36 = value; }
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
