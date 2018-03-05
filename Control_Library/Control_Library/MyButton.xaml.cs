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

namespace Control_Library
{
    /// <summary>
    /// Interaction logic for MyButton.xaml
    /// </summary>
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }



        public FontFamily ButtonFontFamily
        {
            get { return (FontFamily)GetValue(ButtonFontFamilyProperty); }
            set { SetValue(ButtonFontFamilyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonFontFamily.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonFontFamilyProperty =
            DependencyProperty.Register("ButtonFontFamily", typeof(FontFamily), typeof(MyButton), new PropertyMetadata(null));

        


    }
}
