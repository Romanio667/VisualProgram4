using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using System.Windows.Input;
using RNA.Models;
using RNEA.Models;
using AvaloniaApplication1.ViewModels;

namespace RomanNumberAvalonia_Lab4_.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string num1;
        string num2;

        string number;

        public MainWindowViewModel()
        {
            OnClickCommand = ReactiveCommand.Create<string, string>((str) => Greeting =  str);
            ExecuteOperationCommand = ReactiveCommand.Create<string, string>((str) => ExecuteOperation = str);
        }

        public string Greeting
        {
            set
            {
                value = number + value;
                this.RaiseAndSetIfChanged(ref number, value);
               
            }
            get
            {
                return number;
            }
        }

        public string ExecuteOperation
        {
            set
            {
                StringBuilder sb = new StringBuilder(number);
                
                this.RaiseAndSetIfChanged(ref number, value);

            }
            get
            {
                return number;
            }
        }

        public ReactiveCommand<string, string> OnClickCommand { get; }
         public ReactiveCommand<string, string> ExecuteOperationCommand { get; }
    }
}
