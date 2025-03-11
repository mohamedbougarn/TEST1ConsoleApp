using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1ConsoleApp.interfaces
{
    public interface IOperator
    {
        int Priority { get; }
        string Symbol { get; }
        int Execute(int left, int right);

    }
}
