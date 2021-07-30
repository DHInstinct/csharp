using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Assignment3
{
    public interface IRefillable
    {
        void Refill(int amt);
        float FuelPercentage
        { get; }
    }
}
