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

namespace C_sharp_1_практическая
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string player;
        bool queueMain = false;
        Button[] buttons;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[] { one, two, three, four, five, six, seven, eight, nine };
            queue();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            one.IsEnabled = false;
            one.Content = "X";
            queueMain = true;
            player = "X";
            queue();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            two.IsEnabled = false;
            two.Content = "X";
            queueMain = true;
            player = "X";
            queue();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            three.IsEnabled = false;
            three.Content = "X";
            queueMain = true;
            player = "X";
            queue();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            four.IsEnabled = false;
            four.Content = "X";
            queueMain = true;
            player = "X";
            queue();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            five.IsEnabled = false;
            five.Content = "X";
            queueMain = true;
            player = "X";
            queue();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            six.IsEnabled = false;
            six.Content = "X";
            queueMain = true;
            queue();
            player = "X";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            seven.IsEnabled = false;
            seven.Content = "X";
            queueMain = true;
            queue();
            player = "X";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            eight.IsEnabled = false;
            eight.Content = "X";
            queueMain = true;
            queue();
            player = "X";

        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            nine.IsEnabled = false;
            nine.Content = "X";
            queueMain = true;
            queue();
            player = "X";
        }
        private void queue()
        {
            robot();
            check("X");
            check("O");
        }
        private void check(string player)
        {
            string uraPobeda;
            if (player == "X")
            {
                uraPobeda = "win Я";
            }
            else
            {
                uraPobeda = "win не я";
            }

            int hodi = 0;
            foreach (var item in buttons)
            {
                if (item.IsEnabled == false)
                {
                    hodi++;
                }
            }
            if (hodi == 9)
            {
                text.Text = "Ничья";
            }


            if (one.Content.ToString() == player & two.Content.ToString() == player & three.Content.ToString() == player)
            {
                text.Text = uraPobeda;

            }
            else if (four.Content.ToString() == player & five.Content.ToString() == player & six.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
            else if (seven.Content.ToString() == player & eight.Content.ToString() == player & nine.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
            else if (one.Content.ToString() == player & four.Content.ToString() == player & seven.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
            else if (two.Content.ToString() == player & five.Content.ToString() == player & eight.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
            else if (three.Content.ToString() == player & six.Content.ToString() == player & nine.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
            else if (seven.Content.ToString() == player & five.Content.ToString() == player & three.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
            else if (one.Content.ToString() == player & five.Content.ToString() == player & nine.Content.ToString() == player)
            {
                text.Text = uraPobeda;
            }
        }
        private void robot()
        {
            Random random = new Random();
            int i = random.Next(1, 9);
            switch (i)
            {
                case 1:
                    if (one.IsEnabled == false) { robot(); }
                    else if (one.IsEnabled == true && queueMain == true)
                    {
                        one.IsEnabled = false;
                        one.Content = "O";
                        player = "O";
                    }
                    break;
                case 2:
                    if (two.IsEnabled == false) { robot(); }
                    else if (two.IsEnabled == true && queueMain == true)
                    {
                        two.IsEnabled = false;
                        two.Content = "O";
                        player = "O";
                    }
                    break;
                case 3:
                    if (three.IsEnabled == false) { robot(); }
                    else if (three.IsEnabled == true && queueMain == true)
                    {

                        three.IsEnabled = false;
                        three.Content = "O";
                        player = "O";
                    }
                    break;
                case 4:
                    if (four.IsEnabled == false) { robot(); }
                    else if (four.IsEnabled == true && queueMain == true)
                    {
                        four.IsEnabled = false;
                        four.Content = "O";
                        player = "O";
                    }
                    break;
                case 5:
                    if (five.IsEnabled == false) { robot(); }
                    else if (five.IsEnabled == true && queueMain == true)
                    {
                        five.IsEnabled = false;
                        five.Content = "O";
                        player = "O";
                    }
                    break;
                case 6:
                    if (six.IsEnabled == false) { robot(); }
                    else if (six.IsEnabled == true && queueMain == true)
                    {
                        six.IsEnabled = false;
                        six.Content = "O";
                        player = "O";
                    }
                    break;
                case 7:
                    if (seven.IsEnabled == false) { robot(); }
                    else if (seven.IsEnabled == true && queueMain == true)
                    {
                        seven.IsEnabled = false;
                        seven.Content = "O";
                        player = "O";
                    }
                    break;
                case 8:
                    if (eight.IsEnabled == false) { robot(); }
                    else if (eight.IsEnabled && queueMain == true)
                    {
                        eight.IsEnabled = false;
                        eight.Content = "O";
                        player = "O";
                    }
                    break;
                case 9:
                    if (nine.IsEnabled == false) { robot(); }
                    else if (nine.IsEnabled == true && queueMain == true)
                    {
                        nine.IsEnabled = false;
                        nine.Content = "O";
                        player = "O";
                    }
                    break;
            }
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            one.IsEnabled= true;
            one.Content = " ";
            two.IsEnabled= true;
            two.Content = " ";
            three.IsEnabled= true;
            three.Content = " ";
            four.IsEnabled= true;
            four.Content = " ";
            five.IsEnabled= true;
            five.Content = " ";
            six.IsEnabled= true;
            six.Content = " ";
            seven.IsEnabled= true;
            seven.Content = " ";
            eight.IsEnabled= true;
            eight.Content = " ";
            nine.IsEnabled= true;
            nine.Content = " ";
            text.Text = " ";
            queue();

        }
    }
}
