using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zahnrad
{
    /// <summary>
    
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Bt_calculate_Click(object sender, RoutedEventArgs e)
        {
            Double a, b, c, d, e1, h, f, g, i, j, k, n;                
            if (radio_Geradzahnrad.IsChecked == true)
            {
                a = Convert.ToDouble(text_a.Text.ToString());               
                b = Convert.ToDouble(text_b.Text.ToString());
                c = Convert.ToDouble(text_c.Text.ToString());
                d = Convert.ToDouble(text_d.Text.ToString());

                e1 = 0.167 * a;//Definieren e=0,167*a.                     
                h = 2 * a + e1;//Definieren h=2*a+e.
                f = a + e1;//Definieren f=a+e.
                g = a;//Definieren g=a.
                text_e.Text = e1.ToString();                                
                text_f.Text = f.ToString();
                text_g.Text = g.ToString();

                i = Math.PI * a;
                text_i.Text = i.ToString();
                j = c - 2 * (a + e1);//Definieren j=c - 2 * (a + e).
                n = a * (b+2);
                text_j.Text = j.ToString();
                text_n.Text = n.ToString();

                k = a * b * Math.Cos(20 * Math.PI / 180);
                text_k.Text = k.ToString();
            }
            else if(radio_Innenzahnrad.IsChecked == true)
            {
                a = Convert.ToDouble(text_a.Text.ToString());              
                b = Convert.ToDouble(text_b.Text.ToString());
                c = Convert.ToDouble(text_c.Text.ToString());
                d = Convert.ToDouble(text_d.Text.ToString());

                e1 = 0.167 * a;//Definieren e=0,167*a.                    
                h = 2 * a + e1;//Definieren h=2*a+e.
                f = a + e1;//Definieren f=a+e.
                g = a;//Definieren g=a.
                text_e.Text = e1.ToString();                                
                text_f.Text = f.ToString();
                text_g.Text = g.ToString();

                i = Math.PI * a;
                text_i.Text = i.ToString();
                j = c + 2 * (a + e1);//Definieren j=c - 2 * (a + e).
                n = a *(b-2);
                text_j.Text = j.ToString();
                text_n.Text = n.ToString();

                k = a * b * Math.Cos(20 * Math.PI / 180);
                text_k.Text = k.ToString();
            }
            

        }

        private void Radio_Geradzahnrad_Checked(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(@"geradzahnrad.jpg", UriKind.Relative);
            image_kind.Source = new BitmapImage(uri);
        }

        private void Radio_Innenzahnrad_Checked(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(@"innenzahnrad.jpg", UriKind.Relative);
            image_kind.Source = new BitmapImage(uri);
 
        }
    }
}
