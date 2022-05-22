using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Interfaces
{
    public interface IResult
    {
        public bool Status { get; set; }
        public string ErrorMessage { get; set; }
    }
}
