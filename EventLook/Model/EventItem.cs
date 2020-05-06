﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLook.Model
{
    /// <summary>
    /// Represents a event to display. 
    /// Could not inherit EventLogRecord as it doesn't have a public constructor.
    /// </summary>
    public class EventItem
    {
        public EventItem(EventRecord eventRecord)
        {
            Record = eventRecord;
            TimeOfEvent = eventRecord.TimeCreated ?? DateTime.MinValue;
            Message = eventRecord.FormatDescription();
        }
        #region Properties
        public EventRecord Record { get; set; }
        public DateTime TimeOfEvent { get; }
        public string Message { get; }
        #endregion
    }
}