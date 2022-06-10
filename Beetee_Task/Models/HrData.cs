using Microsoft.EntityFrameworkCore;

namespace Beetee_Task.Models
{
    [Keyless]
    public class HrData
    {        
        public int Employee_Id { get; set; }
        public decimal Employee_Salary { get; set; }    
    }
}
