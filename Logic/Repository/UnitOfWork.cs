using Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class UnitOfWork
    {
        private readonly IFundamentalsLogic _fundamentalsLogic;

        public UnitOfWork(IFundamentalsLogic fundamentalsLogic)
        {
            this._fundamentalsLogic = fundamentalsLogic;
        }
    }
}
