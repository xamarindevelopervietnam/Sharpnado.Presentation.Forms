﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharpnado.Presentation.Forms.CustomViews.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomTabItem : TabItem
    {
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(
            nameof(IconImageSource),
            typeof(string),
            typeof(BottomTabItem));

        public static readonly BindableProperty IconUnselectedColorProperty = BindableProperty.Create(
            nameof(IconUnselectedColor),
            typeof(Color),
            typeof(BottomTabItem));

        public BottomTabItem()
        {
            InitializeComponent();
        }

        public string IconImageSource
        {
            get => (string)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }

        public Color IconUnselectedColor
        {
            get => (Color)GetValue(IconUnselectedColorProperty);
            set => SetValue(IconUnselectedColorProperty, value);
        }
    }
}