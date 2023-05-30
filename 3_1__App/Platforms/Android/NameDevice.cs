﻿using Android.Content;
using Android.Locations;
using Android.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1__App
{
    public partial class NameDevice
    {
        public partial string GetName()
        {
            var locationManager = Android.App.Application.Context
                .GetSystemService(Context.LocationService)
                .JavaCast<LocationManager>();

            return locationManager.GnssHardwareModelName;
        }
    }
}
