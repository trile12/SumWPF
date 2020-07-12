using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWPF
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<object> ButtonOne { get; set; }
        public MainViewModel()
        {
            ButtonOne = new DelegateCommand<object>(ButtonActionOne);

        }
        private void ButtonActionOne(object obj)
        {
            Console.WriteLine("please");
            Console.Write("leee");
            Console.Write("Tri");
            int i = 1;
        }
    }
}
