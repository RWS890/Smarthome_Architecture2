using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        //private
        private string resolution;
        private bool recordingStatus;

        // public property
        public string Resolution
        { 
            get { return resolution; }
            set { resolution = value; }
        }
        public bool RecordingStatus
        {
            get { return recordingStatus; }
            set { recordingStatus = value; }
        }

        // consturctor
        public SmartSecurityCamera(string resolutionStatus,
            bool recordingStatus, int smartDeviceID, string smartDeviceName, bool smartDeviceStatus) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        { 
            
        }


            //methods
        public void StartRecording() 
        {
        
        }
        public void StopRecording()
        { 
        
        }

        public override void GetStatus() 
        {
        
        }
    }
}
