using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestSoftware
{
    /// <summary>
    /// Interakční logika pro TestEdit.xaml
    /// </summary>
    public partial class TestEdit : Window
    {
        bool IsUpdating { get; set; }

        public TestEdit()
        {
            InitializeComponent();
            DataContext = new Test();
            IsUpdating = false;
        }

        public TestEdit(Test t)
        {
            InitializeComponent();
            DataContext = t;
            IsUpdating = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Length == 0 || textbox2.Text.Length == 0 ||textbox3.Text.Length == 0 || textbox4.Text.Length == 0 || textbox5.Text.Length == 0 || textbox6.Text.Length == 0 || textbox7.Text.Length == 0 || textbox8.Text.Length == 0 || textbox9.Text.Length == 0 || textbox10.Text.Length == 0 || textbox11.Text.Length == 0 || textbox12.Text.Length == 0 || textbox13.Text.Length == 0 || textbox14.Text.Length == 0 || textbox15.Text.Length == 0 || textbox16.Text.Length == 0 || textbox17.Text.Length == 0 || textbox18.Text.Length == 0 || textbox19.Text.Length == 0 || textbox20.Text.Length == 0)
            {
                errorLabel.Content = "Všechan pole musí být vyplněna!";
            }
            else
            {
                if (IsUpdating == false)
                {
                    Test.Tests.Add((Test)DataContext);
                }
                this.Close();
            }
        }
    }
}
