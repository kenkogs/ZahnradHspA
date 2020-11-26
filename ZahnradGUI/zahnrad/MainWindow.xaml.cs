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
            
            try
            {
                a = Convert.ToDouble(tb_a.Text.ToString());                         // Eingabe von Werten a - d in TextBoxen 
                b = Convert.ToDouble(tb_b.Text.ToString());
                c = Convert.ToDouble(tb_c.Text.ToString());
                d = Convert.ToDouble(tb_d.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie positive reale Werte ein");        // Konsole ploppt auf falls Buchstaben oder negative Werte eingegeben werden.
                return;
            }
            if (a < 0 || b < 0 || c < 0 || d < 0)
            {
                MessageBox.Show("Bitte geben Sie positive reale Werte ein");
                return;
            } 

            if(radio_Geradzahnrad.IsChecked == true)

            {   e1 = 0.167 * a;                                                     //Definierung von e=0,167*a.                     
                h = 2 * a + e1;                                                     //Definierung von  h=2*a+e.
                f = a + e1;                                                         //Definierung von f=a+e.
                g = a;                                                              //Definierung von g=a.
                tb_e.Text = e1.ToString();                                
                tb_f.Text = f.ToString();
                tb_g.Text = g.ToString();

                i = Math.PI * a;
                tb_i.Text = i.ToString();
                j = c - 2 * (a + e1);                                               //Definierung von j=c - 2 * (a + e).
                n = a * (b+2);
                tb_j.Text = j.ToString();
                tb_n.Text = n.ToString();

                k = a * b * Math.Cos(20 * Math.PI / 180);
                tb_k.Text = k.ToString();
            }
            else if(radio_Innenzahnrad.IsChecked == true)
            {
                a = Convert.ToDouble(tb_a.Text.ToString());              
                b = Convert.ToDouble(tb_b.Text.ToString());
                c = Convert.ToDouble(tb_c.Text.ToString());
                d = Convert.ToDouble(tb_d.Text.ToString());

                
                e1 = 0.167 * a;                                                     //Definierung von e=0,167*a.                    
                h = 2 * a + e1;                                                     //Definierung von h=2*a+e.
                f = a + e1;                                                         //Definierung von f=a+e.
                g = a;                                                              //Definierung von g=a.
                tb_e.Text = e1.ToString();                                
                tb_f.Text = f.ToString();
                tb_g.Text = g.ToString();

                i = Math.PI * a;
                tb_i.Text = i.ToString();
                j = c + 2 * (a + e1);                                               //Definierung von j=c - 2 * (a + e).
                n = a *(b-2);
                tb_j.Text = j.ToString();
                tb_n.Text = n.ToString();

                k = a * b * Math.Cos(20 * Math.PI / 180);
              
                tb_k.Text = k.ToString();
            }
            

        }

        private void Radio_Geradzahnrad_Checked(object sender, RoutedEventArgs e)   // JPEG Stirnzahnrad
        {
            Uri uri = new Uri(@"geradzahnrad.jpg", UriKind.Relative);
            image_kind.Source = new BitmapImage(uri);
        }

        private void Radio_Innenzahnrad_Checked(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(@"innenzahnrad.jpg", UriKind.Relative);               // JPEG Innenzahnrad
            image_kind.Source = new BitmapImage(uri);
 
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)                 // Ende btn
        {
            this.Close();
        }
    }
}
