using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public bool? Approved { get; set; }
    }
}
