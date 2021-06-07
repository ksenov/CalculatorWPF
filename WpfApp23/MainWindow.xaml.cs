using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
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

namespace WpfApp23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool plus_ = false;
        bool minus_ = false;
        bool division_ = false;
        bool mult_ = false;
        double member1;
        double member2;
        double result;

        public MainWindow()
        {
            InitializeComponent();
        }
        
       
        private void one_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 1;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 2;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 3;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text +=4;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 5;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 6;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 7;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 8;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 9;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += 0;
        }
        private void point_Click(object sender, RoutedEventArgs e)
        {
            Pole.Text += ",";
        }
        private void percent_Click(object sender, RoutedEventArgs e)
        {
            //Pole.Text +="%";
            string s = Pole.Text;
            string[] array = s.Split('+','-','x','/');
            member1 = Convert.ToDouble(array[0]);
            member2 = Convert.ToDouble(array[1]);
            member2 = member1 * member2 / 100;
            array[1] = Convert.ToString(member2);
            if(plus_==true)
            {
                result = member1 + member2;
                plus_ = false;
                member1 = 0;
                member2 = 0;
            }
            if (minus_ == true)
            {
                result = member1 - member2;
                minus_ = false;
                member1 = 0;
                member2 = 0;
            }
            if (division_ == true)
            {
                result = member1 / member2;
                division_ = false;
                member1 = 0;
                member2 = 0;
            }
            if (mult_ == true)
            {
                result = member1 * member2;
                mult_ = false;
                member1 = 0;
                member2 = 0;
            }
            
            Pole.Text = Convert.ToString(result);
            //Pole.Text = Convert.ToString(array);
           
        }
        private void sign_Click(object sender, RoutedEventArgs e)
        {
            member1 = Convert.ToDouble(Pole.Text);
            member1 += member1 * -2;
            Pole.Text = Convert.ToString(member1);
            member1 = 0;
            

            //Pole.Text.Insert(0, "-");
        }
        public void plus_Click(object sender, RoutedEventArgs e)
        {
            member1 = Convert.ToDouble(Pole.Text);
            Pole.Text += "+";
             plus_ = true;
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            member1 = Convert.ToDouble(Pole.Text);
            Pole.Text += "-";
            minus_ = true;
        }
        private void division_Click(object sender, RoutedEventArgs e)
        {
            member1 = Convert.ToDouble(Pole.Text);
            Pole.Text += "/";
            division_ = true;
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            member1 = Convert.ToDouble(Pole.Text);
            Pole.Text += "x";
            mult_ = true;
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            member1 = 0;
            member2 = 0;
            Pole.Text = "";
        }
        public void equal_Click(object sender, RoutedEventArgs e)
        {
            if (plus_ == true)
            {
                string s = Pole.Text;
                string[] array = s.Split('+');
                member2 = Convert.ToDouble(array[1]);

                result = member1 + member2;
                Pole.Text = Convert.ToString(result);
                plus_ = false;
                member1 = 0;
                member2 = 0;
            }
            if (minus_ == true)
            {
                string s = Pole.Text;
                string[] array = s.Split('-');
                member2 = Convert.ToDouble(array[1]);

                result = member1 - member2;
                Pole.Text = Convert.ToString(result);
                minus_ = false;
                member1 = 0;
                member2 = 0;
            }
            if (division_ == true)
            {
                
                string s = Pole.Text;
                string[] array = s.Split('/');
                member2 = Convert.ToDouble(array[1]);

                result = member1 / member2;
                Pole.Text = Convert.ToString(result);
                division_ = false;
                member1 = 0;
                member2 = 0;
                s = Convert.ToString(array);
                
            }
            if (mult_ == true)
            {
                string s = Pole.Text;
                string[] array = s.Split('x');
                member2 = Convert.ToDouble(array[1]);

                result = member1 * member2;
                Pole.Text = Convert.ToString(result);
                mult_ = false;
                member1 = 0;
                member2 = 0;
                s = Convert.ToString(array);
            }

        }


    }
}
