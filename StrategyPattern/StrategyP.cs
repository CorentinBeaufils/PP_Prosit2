using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IOperationStrategy
    {
        int Execute(int a, int b);
    }

    public class AdditionStrategy : IOperationStrategy
    {
        public int Execute(int a, int b) { return a + b; }
    }

    public class SubstractStrategy : IOperationStrategy {
        public int Execute(int a, int b) { return a- b; }
    }

    public class MultiplicationStrategy : IOperationStrategy
    {
        public int Execute(int a ,  int b) { return a*b; }
    }


    public class Calculator
    {
        private IOperationStrategy strategy;
        public Calculator(IOperationStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IOperationStrategy operationStrategy)
        {
            strategy = operationStrategy;
        }

        public int DoOperation(int a,int b) { 
            return strategy.Execute(a,b);
        }
    }
}
