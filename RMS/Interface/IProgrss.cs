using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RMS.Interface
{
    internal interface IProgrss
    {
        bool IsBusy { get; set; }
        Visibility MainTaskVisible { get; set; }
        string MainTaskText { get; set; }
        bool MainTaskInderminate { get; set; }
        double MainTaskMinimumValue { get; set; }
        double MainTaskMaximumValue { get; set; }
        double MainTaskValue { get; set; }
        Visibility SubTaskVisible { get; set; }
        string SubTaskText { get; set; }
        bool SubTaskInderminate { get; set; }
        double SubTaskMinimumValue { get; set; }
        double SubTaskMaximumValue { get; set; }
        double SubTaskValue { get; set; }
    }
}
