using RMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RMS.Commands
{
    internal class commandMain 
    {


        public vmMain callerVM;

        public commandMain(vmMain vm) 
        {
            callerVM = vm;
        }



        internal class mangeemployeeMain : ICommand
        {

            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
                // throw new NotImplementedException();
            }

            public void Execute(object? parameter)
            {

            }
        }
    }
}
