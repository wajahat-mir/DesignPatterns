using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    class Context
    {
        private IStrategy _strategy;

        public void setStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void executeStrategy()
        {
            _strategy.execute();
        }
    }
}
