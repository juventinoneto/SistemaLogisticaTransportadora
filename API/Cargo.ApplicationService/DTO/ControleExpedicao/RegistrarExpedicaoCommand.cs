using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleExpedicao
{
    public class RegistrarExpedicaoCommand
    {
        public IEnumerable<int> IdsColetas { get; set; }

        public DateTime Data { get; set; }  
    }
}
