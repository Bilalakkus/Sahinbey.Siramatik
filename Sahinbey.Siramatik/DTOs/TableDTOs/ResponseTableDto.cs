using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.DTOs.TableDTOs
{
    public class ResponseTableDto
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public bool IsItActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
