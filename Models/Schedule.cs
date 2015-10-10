using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetBr.Api.Models
{
    public class Schedule
    {
      public int Id { get; set; }

        public List<ScheduleItem> ScheduleItems { get; set; }
        public Track Track { get; set; }
    }

    public class ScheduleItem
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string TimeInfo { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string Title { get; set; }
        public Talk Talk { get; set; }
    }
}
