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

namespace HM1
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

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            int numA;
            int numB;
            int numC;
            if(int.TryParse(NumA.Text, out numA) && int.TryParse(NumB.Text, out numB) && int.TryParse(NumC.Text, out numC))
            {
                Rectangle Rect = new Rectangle(numA, numB, numC);
                HorizontNumber.Text = Rect.NumOfRectHorizontal.ToString();
                VerticalNumber.Text = Rect.NumOfRectVertical.ToString();
                SummNumber.Text = Rect.NumOfRectSumm.ToString();
                MessageText.Text = "Все OK";
            }
            else
            {
                MessageText.Text = "Вы ввели не действительное число попробуйте снова";
            }
        }
    }
}
