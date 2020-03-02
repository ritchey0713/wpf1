﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  public partial class MainWindow : Window {

    //custom dependency property 
    public int MyProperty
    {
      get { return (int)GetValue(MyDependencyProperty);  }
      set { SetValue(MyDependencyProperty, value); }
    }

    public static readonly DependencyProperty MyDependencyProperty =
      DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

    public Sum sumObj { get; set;}
    public MainWindow() {
      InitializeComponent();

      sumObj = new Sum { Num1 = "1", Num2 = "10" };
      this.DataContext = sumObj;

      //Grid grid = new Grid();
      //this.Content = grid;
      //Button btn = new Button();
      //btn.Height = 250;
      //btn.Width = 500;
      //btn.FontSize = 40;

      //WrapPanel wrapPanel = new WrapPanel();
      //TextBlock txt = new TextBlock();
      //txt.Text = "Multi";
      //txt.Foreground = Brushes.Blue;
      //wrapPanel.Children.Add(txt);

      //TextBlock txt2 = new TextBlock();
      //txt2.Text = "Color";
      //txt2.Foreground = Brushes.Red;
      //wrapPanel.Children.Add(txt2);

      //TextBlock txt3 = new TextBlock();
      //txt3.Text = "Button";
      //txt3.Foreground = Brushes.Green;
      //wrapPanel.Children.Add(txt3);

      //btn.Content = wrapPanel;
      //grid.Children.Add(btn);

      //MySlider.Value = 30;
      //MyTextBox.Text = MySlider.Value.ToString();


    }



    private void Button_Click(object sender, RoutedEventArgs e) {
      MessageBox.Show("Thanks for finding me!");

    }

    // bubbling event
    private void Button_MouseUp(object sender, MouseButtonEventArgs e) {
      MessageBox.Show("You released me!");
    }

    // tunneling event
    private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
      MessageBox.Show("Released event!");
    }
  }
}
