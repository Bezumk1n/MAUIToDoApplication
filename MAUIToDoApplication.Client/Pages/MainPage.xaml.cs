﻿namespace MAUIToDoApplication.Client.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageVM context)
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}