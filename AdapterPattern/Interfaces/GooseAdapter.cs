using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    internal class GooseAdapter : Duck
    {
        private Goose goose = null!;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Fly()
        {
            goose.Fly();
        }
        public void Quack()
        {
            goose.Honk();
        }
    }
}