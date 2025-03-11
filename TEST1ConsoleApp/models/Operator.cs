using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST1ConsoleApp.interfaces;

namespace TEST1ConsoleApp.models
{
   public class AddOperator : IOperator
{
    public int Priority => 1;
    public string Symbol => "+";
    public int Execute(int left, int right) => left + right;
}
   public class SubtractOperator : IOperator
{
    public int Priority => 1;
    public string Symbol => "-";
    public int Execute(int left, int right) => left - right;
}
    public class MultiplyOperator : IOperator
{
    public int Priority => 2;
    public string Symbol => "*";
    public int Execute(int left, int right) => left * right;
}
}
