using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class ScheduleViewModel
    {
        public ScheduleAppointmentCollection Appointments { get; set; } = new ScheduleAppointmentCollection();
        public ScheduleViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                var appointment = new ScheduleAppointment();
                appointment.StartTime = DateTime.Now.Date.AddHours(10).AddDays(i);
                appointment.EndTime = appointment.StartTime.AddHours(2);
                appointment.Color = Color.Red;
                appointment.Subject = appointment.StartTime.ToString();
                Appointments.Add(appointment);
            }

        }
    }
}

  
