using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {

        //private fields
        private double currentTempature;
        private double targetTempature;
        //public properties
        public double CurrentTempature
        {
            get { return currentTempature; }
            set { currentTempature = value; }
        }

        public double TargetTempature
        {
            get { return targetTempature; }
            set { targetTempature = value; }
        }
        //constructor

        public SmartThermostat(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus, double smartCurrentTempature, double smartTargetTempature) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {

        }
        public void setTempature() 
        {
        
        }

        public void setCurrentTempature() 
        {
        
        }

        public override void GetStatus() 
        {
        
        }
    }
}
