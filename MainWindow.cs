using System.Windows;
using System.Windows.Input;
using System.Windows.Controls; // for OnGotFocusHandler
using System.Windows.Media; // for OnGotFocusHandler
using System.Diagnostics; // for debug

namespace KeyboardKey {
  public partial class MainWindow : Window  {
    public MainWindow() {
      InitializeComponent();
    }

    private string hGetFocus(TextBox tb) { // return the status of Logical/Keyboard focus
      var txtFocus = "";
      if (tb.IsFocused)        	{ txtFocus += "+lF ";} else {txtFocus += "−lF ";}
      if (tb.IsKeyboardFocused)	{ txtFocus += "+kF" ;} else {txtFocus += "−kF" ;}
      return txtFocus;
    }
    private void OnGotFocusHandler(object sender, RoutedEventArgs e) {
      // TextBox gains Logical focus. Δ bg color to Lavender, border to thick Orange
      var tb            	= e.Source as TextBox;
      tb.Background     	= Brushes.Lavender;
      tb.BorderBrush    	= Brushes.Orange;
      tb.BorderThickness	= new Thickness(5,3,5,3); // ←↑→↓
      textBlock.Text    	= hGetFocus(tb);
      Debug.WriteLine("+Gained Logical focus @OnGotFocusHandler");
    }
    private void OnLostFocusHandler(object sender, RoutedEventArgs e) {
      // TextBox loses Logical focus. Δ bg color to White, border to regular Black
      var tb            	= e.Source as TextBox;
      tb.Background     	= Brushes.White;
      tb.BorderBrush    	= Brushes.Black;
      tb.BorderThickness	= new Thickness(1,1,1,1);
      textBlock.Text    	= hGetFocus(tb);
      Debug.WriteLine("−Lost Logical focus @OnLostFocusHandler");
    }
    private void OnGotKeyboardFocusHandler(object sender, RoutedEventArgs e) {
      // TextBox gains Keyboard focus. Δ bg color to Yellow
      var tb        	= e.Source as TextBox;
      tb.Background 	= Brushes.Yellow;
      textBlock.Text	= hGetFocus(tb);
      Debug.WriteLine("+Gained Keyboard focus @OnGotKeyboardFocusEvent");
    }
    private void OnLostKeyboardFocusHandler(object sender, RoutedEventArgs e) {
      // TextBox loses Keyboard focus. Δ bg color to White
      var tb        	= e.Source as TextBox;
      tb.Background 	= Brushes.White;
      textBlock.Text	= hGetFocus(tb);
      Debug.WriteLine("−Lost Keyboard focus @OnLostKeyboardFocusEvent");
    }


    private void OnGotFocus_FileMenuHandler(object sender, RoutedEventArgs e) {
      // Menu File gains Logical focus. Δ bg color to Lavender, border to thick Orange
      // var tb            	= e.Source as Menu File;
      // tb.Background     	= Brushes.Lavender;
      // tb.BorderBrush    	= Brushes.Orange;
      // tb.BorderThickness	= new Thickness(5,3,5,3); // ←↑→↓
      // textBlock.Text    	= hGetFocus(tb);
      Debug.WriteLine("+Gained Logical focus @OnGotFocus_FileMenuHandler");
    }
    private void OnLostFocus_FileMenuHandler(object sender, RoutedEventArgs e) {
      // Menu File loses Logical focus. Δ bg color to White, border to regular Black
      // var tb            	= e.Source as Menu File;
      // tb.Background     	= Brushes.White;
      // tb.BorderBrush    	= Brushes.Black;
      // tb.BorderThickness	= new Thickness(1,1,1,1);
      // textBlock.Text    	= hGetFocus(tb);
      Debug.WriteLine("−Lost Logical focus @OnLostFocus_FileMenuHandler");
    }
    private void OnGotKeyboardFocus_FileMenuHandler(object sender, RoutedEventArgs e) {
      // Menu File gains Keyboard focus. Δ bg color to Yellow
      // var tb        	= e.Source as Menu File;
      // tb.Background 	= Brushes.Yellow;
      // textBlock.Text	= hGetFocus(tb);
      Debug.WriteLine("+Gained Keyboard focus @OnGotKeyboardFocus_FileMenuHandler");
    }
    private void OnLostKeyboardFocus_FileMenuHandler(object sender, RoutedEventArgs e) {
      // Menu File loses Keyboard focus. Δ bg color to White
      // var tb        	= e.Source as Menu File;
      // tb.Background 	= Brushes.White;
      // textBlock.Text	= hGetFocus(tb);
      Debug.WriteLine("−Lost Keyboard focus @OnLostKeyboardFocus_FileMenuHandler");
    }
  }
}
