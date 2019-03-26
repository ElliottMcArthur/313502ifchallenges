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

namespace _313502IfChallenges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Number;

           
            int.TryParse(Box1.Text, out Number);
      
            if (Number == 0)
            {
                MessageBox.Show("Your Number is Zero");
            }
            if (Number < 0)
            {
                MessageBox.Show("Your Number is Negative");
            }
            if (Number > 0)
            {
                MessageBox.Show("Your Number is Posotive");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int Number;

            int.TryParse(Box2.Text, out Number);

            if (Number %2 == 0)
            {
                MessageBox.Show("This  Number Is Even");
            }
            else
            {
                MessageBox.Show("This Number Is Odd");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int Char;

            int.TryParse(Box3.Text, out Char);           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Box4.Text = Box4.Text.ToLower();
            char theLetter = Box4.Text[0];
            bool isVowel = false;

            if (theLetter == 'a')
            {
                isVowel = true;
            }

            if (theLetter == 'e')
            {
                isVowel = true;
            }

            if (theLetter == 'i')
            {
                isVowel = true;
            }

            if (theLetter == 'o')
            {
                isVowel = true;
            }

            if (theLetter == 'u')
            {
                isVowel = true;
            }

            if (theLetter == 'y')
            {
                isVowel = true;
            }
          
            if (isVowel)
            {
                MessageBox.Show("This Is a Vowel");
            }
            else
            {
                MessageBox.Show("This Is a Consonant");
            }

        }
    }
}
