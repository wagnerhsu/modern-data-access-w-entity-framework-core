﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 30/12/2017 23:45:03
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace EFC_EntityDeveloper
{
    public partial class Pilot {

        public Pilot()
        {
            this.Flights = new List<Flight>();
            OnCreated();
        }

        public virtual int PersonID
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> LicenseDate
        {
            get;
            set;
        }

        public virtual string Flightscheintyp
        {
            get;
            set;
        }

        public virtual System.Nullable<int> FlightHours
        {
            get;
            set;
        }

        public virtual string FlightSchool
        {
            get;
            set;
        }

        public virtual IList<Flight> Flights
        {
            get;
            set;
        }

        public virtual Employee Employee
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
