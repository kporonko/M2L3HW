using LoggerAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced
{
    public class Result : IResult
    {
        public bool Status { get; set; }
        public string ErrorMessage { get; set; }
    }
}
