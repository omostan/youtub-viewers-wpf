﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewerDetailsFormViewModel : ViewModelBase
    {

		private string _username;

		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
				OnPropertyChanged(nameof(CanSubmit));
			}
		}


		private bool _isSubscribed;

		public bool IsSubscribed
		{
			get
			{
				return _isSubscribed;
			}
			set
			{
				_isSubscribed = value;
				OnPropertyChanged(nameof(IsSubscribed));
			}
		}


		private bool _isMember;

        public bool IsMember
		{
			get
			{
				return _isMember;
			}
			set
			{
				_isMember = value;
				OnPropertyChanged(nameof(IsMember));
			}
		}


		private bool isSubmitting;

		public bool IsSubmitting
		{
			get
			{
				return isSubmitting;
			}
			set
			{
				isSubmitting = value;
				OnPropertyChanged(nameof(IsSubmitting));
			}
		}

        private string _errorMessage;

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public bool CanSubmit => !string.IsNullOrEmpty(Username);

        public ICommand SubmitCommand { get; }
		public ICommand CancelCommand { get; }

        public YoutubeViewerDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }
    }
}