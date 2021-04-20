﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DentalCare
{
    class Agenda
    {
        private List<Day> days;
        private List<Time> times;
        private List<Schedule> schedules;
        private List<Patient> patients;
        private List<Appointment> appointments;

        public Agenda()
        {
            //"0|Lunes" => ["0", "Lunes"]

            days = EasyFile<Day>.LoadDataFromFile("days.txt",
                    tokens => new Day(Convert.ToInt32(tokens[0]),
                                      tokens[1]));
        }
    }
}