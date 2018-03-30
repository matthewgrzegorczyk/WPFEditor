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

namespace PS3
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

        private void OnSliderBackgroundChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            my_label.Background = new SolidColorBrush(Color.FromRgb((byte) c_bg_red.Value, (byte) c_bg_green.Value, (byte) c_bg_blue.Value));
        }

        private void OnContentKeyUp(object sender, KeyEventArgs e)
        {
            my_label.Content = ((TextBox)sender).Text;
        }

        private void OnAlignmentChecked(object sender, RoutedEventArgs e)
        {
            StackPanel stack_panel = (StackPanel) sender;
            RadioButton radio_button = (RadioButton) e.Source;
            
            if(stack_panel.Tag.Equals("horizontal"))
            {
                my_label.HorizontalAlignment = (HorizontalAlignment) this.SetAlignment(HorizontalAlignment, radio_button.Tag.ToString());
            }
            else if (stack_panel.Tag.Equals("vertical"))
            {
                my_label.VerticalAlignment = (VerticalAlignment) this.SetAlignment(VerticalAlignment, radio_button.Tag.ToString());
            }
        }

        private void OnContentAlignmentChecked(object sender, RoutedEventArgs e)
        {
            StackPanel stack_panel = (StackPanel)sender;
            RadioButton radio_button = (RadioButton)e.Source;

            if (stack_panel.Tag.Equals("horizontal"))
            {
                my_label.HorizontalContentAlignment = (HorizontalAlignment)this.SetAlignment(HorizontalAlignment, radio_button.Tag.ToString());
            }
            else if (stack_panel.Tag.Equals("vertical"))
            {
                my_label.VerticalContentAlignment = (VerticalAlignment)this.SetAlignment(VerticalAlignment, radio_button.Tag.ToString());
            }
        }

        private object SetAlignment(object alignment_type, String alignment)
        {
            switch(alignment)
            {
                case "left":
                    return HorizontalAlignment.Left;
                case "center":
                    if (alignment_type.Equals(HorizontalAlignment))
                    {
                        return HorizontalAlignment.Center;
                    }
                    else if (alignment_type.Equals(VerticalAlignment))
                    {
                        return VerticalAlignment.Center;
                    }
                    break;
                case "right":
                    return HorizontalAlignment.Right;
                case "stretch":
                    if (alignment_type.Equals(HorizontalAlignment))
                    {
                        return HorizontalAlignment.Stretch;
                    }
                    else if (alignment_type.Equals(VerticalAlignment))
                    {
                        return VerticalAlignment.Stretch;
                    }
                    break;
                case "top":
                    return VerticalAlignment.Top;
                case "bottom":
                    return VerticalAlignment.Bottom;
                default:
                    MessageBox.Show("Houston mamy problem. Zły alignment.");
                    break;
            }

            return null;
        }

        private object SetContentAlignment(string alignment_type, String alignment)
        {
            switch (alignment)
            {
                case "left":
                    return HorizontalAlignment.Left;
                case "center":
                    if (alignment_type.Equals("horizontal"))
                    {
                        return HorizontalAlignment.Center;
                    }
                    else if (alignment_type.Equals("vertical"))
                    {
                        return VerticalAlignment.Center;
                    }
                    break;
                case "right":
                    return HorizontalAlignment.Right;
                case "stretch":
                    if (alignment_type.Equals("horizontal"))
                    {
                        return HorizontalAlignment.Stretch;
                    }
                    else if (alignment_type.Equals("vertical"))
                    {
                        return VerticalAlignment.Stretch;
                    }
                    break;
                case "top":
                    return VerticalAlignment.Top;
                case "bottom":
                    return VerticalAlignment.Bottom;
                default:
                    MessageBox.Show("Houston mamy problem. Zły alignment.");
                    break;
            }
            return null;
        }

        private void OnBoldUnchecked(object sender, RoutedEventArgs e)
        {
            my_label.FontWeight = FontWeights.Normal;
        }

        private void OnBoldChecked(object sender, RoutedEventArgs e)
        {
            my_label.FontWeight = FontWeights.Bold;
        }

        private void OnItalicUnchecked(object sender, RoutedEventArgs e)
        {
            my_label.FontStyle = FontStyles.Normal;
        }

        private void OnItalicChecked(object sender, RoutedEventArgs e)
        {
            my_label.FontStyle = FontStyles.Italic;
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            my_label.Content = sender.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            my_label.Content = sender.ToString();
        }

        private void OnForegroundColorKeyUp(object sender, KeyEventArgs e)
        {
            string color = "#" + c_fg_red.Text + c_fg_green.Text + c_fg_blue.Text;

            if (color.Length == 7)
            {
                try
                {
                    Color foreground = (Color)ColorConverter.ConvertFromString(color);
                    my_label.Foreground = new SolidColorBrush(foreground);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void OnMarginValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            my_label.Margin = new Thickness(c_margin.Value);
        }

        private void OnPaddingValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            my_label.Padding = new Thickness(c_padding.Value);
        }
    }
}
