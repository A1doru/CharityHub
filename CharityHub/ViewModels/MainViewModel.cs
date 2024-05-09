﻿using CharityHub.ViewModels.AuthentificationViewModels;

namespace CharityHub.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
        }
    }
}
