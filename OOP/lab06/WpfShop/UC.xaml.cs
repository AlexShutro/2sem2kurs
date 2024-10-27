﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace WpfShop
{
    /// <summary>
    /// Логика взаимодействия для UC1.xaml
    /// </summary>
    public partial class UC : Button
    {
        public event EventHandler CustomClick;

        public static readonly DependencyProperty CustomBackgroundProperty =
               DependencyProperty.Register("CustomBackground", typeof(Color), typeof(UC),
                   new FrameworkPropertyMetadata(Colors.Red,
                       FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                       new PropertyChangedCallback(OnCustomBackgroundChanged),
                       new CoerceValueCallback(CoerceCustomBackground),
                       true),
                   new ValidateValueCallback(IsValidColor));

        public Color CustomBackground
        {
            get { return (Color)GetValue(CustomBackgroundProperty); }
            set { SetValue(CustomBackgroundProperty, value); }
        }

        private static bool IsValidColor(object value)
        {
            return value is Color;
        }

        private static void OnCustomBackgroundChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            UC button = (UC)obj;
            button.Background = new SolidColorBrush((Color)args.NewValue);
        }

        private static object CoerceCustomBackground(DependencyObject obj, object value)
        {
            if (value == null || !(value is Color))
            {
                return Colors.Red;
            }
            else
            {
                return value;
            }
        }

        public UC() : base()
        {
            Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);
            Color newColor = Color.FromArgb(255, colorBytes[0], colorBytes[1], colorBytes[2]);
            CustomBackground = newColor;

            CustomClick?.Invoke(this, EventArgs.Empty);
        }

        private void MyButton_CustomClick(object sender, EventArgs e)
        {
            Random random = new Random();
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);
            Color newColor = Color.FromArgb(255, colorBytes[0], colorBytes[1], colorBytes[2]);
            CustomBackground = newColor;

            CustomClick?.Invoke(this, EventArgs.Empty);
        }

        public static readonly RoutedEvent CustomClickDirectEvent = EventManager.RegisterRoutedEvent(
       "CustomClickDirect", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UC));

        public static readonly RoutedEvent CustomClickTunnelingEvent = EventManager.RegisterRoutedEvent(
        "CustomClickTunneling", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(UC));

        public static readonly RoutedEvent CustomClickBubblingEvent = EventManager.RegisterRoutedEvent(
        "CustomClickBubbling", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UC));

        public event RoutedEventHandler CustomClickDirect
        {
            add { AddHandler(CustomClickDirectEvent, value); }
            remove { RemoveHandler(CustomClickDirectEvent, value); }
        }

        public event RoutedEventHandler CustomClickTunneling
        {
            add { AddHandler(CustomClickTunnelingEvent, value); }
            remove { RemoveHandler(CustomClickTunnelingEvent, value); }
        }

        public event RoutedEventHandler CustomClickBubbling 
        {
            add { AddHandler(CustomClickBubblingEvent, value); }
            remove { RemoveHandler(CustomClickBubblingEvent, value); }
        }

        private void RaiseCustomClickEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(CustomClickBubblingEvent);
            RoutedEventArgs newEventArgs1 = new RoutedEventArgs(CustomClickTunnelingEvent);
            RoutedEventArgs newEventArgs2 = new RoutedEventArgs(CustomClickDirectEvent);
            RaiseEvent(newEventArgs);
        }

        protected override void OnClick()
        {
            RaiseCustomClickEvent();
            base.OnClick();

        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(CustomClickBubblingEvent);
            args.Source = e.Source;
            RaiseEvent(args);
            base.OnMouseLeftButtonDown(e);

        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(CustomClickBubblingEvent);
            args.Source = e.Source;
            RaiseEvent(args);
            base.OnMouseDown(e);
        }
    }
}





