using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Kitty
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer GameTimer = new DispatcherTimer();
        double score;
        int Gravity = 8;
        bool GameOver;
        Rect CatHitBox;

        public MainWindow()
        {
            
            InitializeComponent();
            GameTimer.Tick += MainEventTimer;
            GameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();
        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            Score.Content = "Score: " + score;
            CatHitBox = new Rect(Canvas.GetLeft(Cat), Canvas.GetTop(Cat), Cat.Width, Cat.Height);
            Canvas.SetTop(Cat, Canvas.GetTop(Cat) + Gravity);

            if (Canvas.GetTop(Cat)<-10|| Canvas.GetTop(Cat) > 458)
            {
                EndGame();
            }
            
            foreach (var x in Board.Children.OfType<Image>())
            {
                if ((string)x.Tag=="Fish1"|| (string)x.Tag == "Fish2"||(string)x.Tag == "Fish3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);
                    if (Canvas.GetLeft(x)<-100)
                    {
                        Canvas.SetLeft(x, 800);
                        score += .5; //dwie przeszkody (góra oraz dół) dają jeden punkt
                    }
                    Rect FishHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);
                    if (CatHitBox.IntersectsWith(FishHitBox))
                    {
                        EndGame();
                    }
                }
                if ((string)x.Tag == "Cloud")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 1);
                        
                        if (Canvas.GetLeft(x)<-250)
                        {
                            Canvas.SetLeft(x, 550);
                        }
    
                        
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs y)
        {
            if (y.Key==Key.Space)
            {
                Cat.RenderTransform = new RotateTransform(-20, Cat.Width / 2, Cat.Height / 2);
                Gravity = -8;
            }
            if (y.Key==Key.R && GameOver==true)
            {
                StartGame();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Cat.RenderTransform = new RotateTransform(5, Cat.Width / 2, Cat.Height / 2);
            Gravity = 8;
        }

        public void StartGame()
        {
            Board.Focus();
            int temp = 300;
            score = 0;
            GameOver = false;
            Canvas.SetTop(Cat, 190);
            foreach (var x in Board.Children.OfType<Image>())
            {
                if ((string)x.Tag=="Fish1")
                {
                    Canvas.SetLeft(x, 500);
                }
               
                if ((string)x.Tag == "Fish2")
                {
                    Canvas.SetLeft(x, 800);
                }
              
                if ((string)x.Tag == "Fish3")
                {
                    Canvas.SetLeft(x, 1100);
                }
                if ((string)x.Tag == "Cloud")
                {
                    Canvas.SetLeft(x, 300+temp);
                    temp = 800;
                }
            }
            GameTimer.Start();
        }
    private void EndGame()
        {
            GameTimer.Stop();
            GameOver = true;
            Score.Content += "Game Over! Press R to play again";
        }
    }
}
