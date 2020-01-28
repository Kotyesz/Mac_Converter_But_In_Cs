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

namespace MacConverter
{
    public partial class MainWindow : Window
    {
        #region Main
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region Functions
        void ConversionOne()
        {
            try
            {
                char[] FirstMac = { '0', '0', ':', '0', '0', ':', '0', '0', ':', '0', '0', ':', '0', '0', ':', '0', '0' };
                FirstMac = MacInput.Text.ToCharArray();
                char[] SecondMac = { '0', '0', '0', '0', '.', '0', '0', '0', '0', '.', '0', '0', '0', '0' };

                SecondMac[0] = FirstMac[0];
                SecondMac[1] = FirstMac[1];
                SecondMac[2] = FirstMac[3];
                SecondMac[3] = FirstMac[4];

                SecondMac[5] = FirstMac[6];
                SecondMac[6] = FirstMac[7];
                SecondMac[7] = FirstMac[9];
                SecondMac[8] = FirstMac[10];

                SecondMac[10] = FirstMac[12];
                SecondMac[11] = FirstMac[13];
                SecondMac[12] = FirstMac[15];
                SecondMac[13] = FirstMac[16];

                MacInput2.Text = new string(SecondMac);
            }
            catch (Exception e)
            {
                MacInput2.Text = "Túl rövid";
            }
        }
        void ConversionTwo()
        {
            try
            {
                char[] SecondMac = { '0', '0', '0', '0', '.', '0', '0', '0', '0', '.', '0', '0', '0', '0' };
                SecondMac = MacInput2.Text.ToCharArray();
                char[] FirstMac = { '0', '0', ':', '0', '0', ':', '0', '0', ':', '0', '0', ':', '0', '0', ':', '0', '0' };

                FirstMac[0] = SecondMac[0];
                FirstMac[1] = SecondMac[1];

                FirstMac[3] = SecondMac[2];
                FirstMac[4] = SecondMac[3];


                FirstMac[6] = SecondMac[5];
                FirstMac[7] = SecondMac[6];

                FirstMac[9] = SecondMac[7];
                FirstMac[10] = SecondMac[8];


                FirstMac[12] = SecondMac[10];
                FirstMac[13] = SecondMac[11];

                FirstMac[15] = SecondMac[12];
                FirstMac[16] = SecondMac[13];

                MacInput.Text = new string(FirstMac);
            }
            catch (Exception e)
            {
                MacInput.Text = "Túl rövid";
            }
        }

        #endregion
        #region Listeners
        private void Conv1Button_Click(object sender, RoutedEventArgs e)
        {
            ConversionOne();
        }

        private void Conv2Button_Click(object sender, RoutedEventArgs e)
        {
            ConversionTwo();
        }

        private void MacInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ConversionOne();
            }
        }

        private void MacInput2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ConversionTwo();
            }
        }
        #endregion
    }
}
