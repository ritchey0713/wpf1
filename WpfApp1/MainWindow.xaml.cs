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

      //sumObj = new Sum { Num1 = "1", Num2 = "10" };
      //this.DataContext = sumObj;

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

      List<Match> matches = new List<Match>();

      matches.Add(new Match() { Team1 = "Cloud 9", Team2 = "CLG", Score1 = 10, Score2 = 8, Completion = 22});
      matches.Add(new Match() { Team1 = "Liquid", Team2 = "TSM", Score1 = 37, Score2 = 49, Completion = 84 });
      matches.Add(new Match() { Team1 = "100 Theives", Team2 = "FlyQuest", Score1 = 22, Score2 = 67, Completion = 100 });
      matches.Add(new Match() { Team1 = "Evil Geniuses", Team2 = "Immortals", Score1 = 1, Score2 = 1, Completion = 10 });
      matches.Add(new Match() { Team1 = "Dignitas", Team2 = "Golden Guardians", Score1 = 55, Score2 = 51, Completion = 100 });

      // itemssource is where the listbox gets its list of data
      lbMatches.ItemsSource = matches;
    }

    public class Match
    {
      public int Score1 { get; set; }
      public int Score2 { get; set; }
      public string Team1 { get; set; }
      public string Team2 { get; set; }
      public int Completion { get; set; }
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

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
      if(lbMatches.SelectedItem != null)
      {
        MessageBox.Show("Selected match: " +
          // use as keyword to access the Match class methods
         (lbMatches.SelectedItem as Match).Team1 + " " +
           (lbMatches.SelectedItem as Match).Score1 + " " +
           (lbMatches.SelectedItem as Match).Team2 + " " +
           (lbMatches.SelectedItem as Match).Score2 + " ");
      }
    }
  }
}
