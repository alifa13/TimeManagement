using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Data.DTOs
{
    public class ParameterDTO
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public SqlDbType Type { get; set; }
    }
}
