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
    public partial class FlightsFromRome {

        public FlightsFromRome()
        {
            OnCreated();
        }

        public virtual int FlightNo
        {
            get;
            set;
        }

        public virtual string Departure
        {
            get;
            set;
        }

        public virtual System.DateTime FlightDate
        {
            get;
            set;
        }

        public virtual string Destination
        {
            get;
            set;
        }

        public virtual bool NonSmokingFlight
        {
            get;
            set;
        }

        public virtual short Seats
        {
            get;
            set;
        }

        public virtual string Memo
        {
            get;
            set;
        }

        public virtual System.Nullable<short> FreeSeats
        {
            get;
            set;
        }

        public virtual System.Nullable<int> PilotPersonID
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
