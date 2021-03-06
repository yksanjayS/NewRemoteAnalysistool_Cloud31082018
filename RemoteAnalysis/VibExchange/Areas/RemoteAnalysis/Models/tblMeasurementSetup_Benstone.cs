//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VibExchange.Areas.RemoteAnalysis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMeasurementSetup_Benstone
    {
        public int SetupID { get; set; }
        public int FileID { get; set; }
        public int MeasureID { get; set; }
        public Nullable<int> AlarmID { get; set; }
        public string acc_filter { get; set; }
        public string vel_filter { get; set; }
        public string displ_filter { get; set; }
        public string crest_factor_filter { get; set; }
        public string bearing_acc_hp_filter { get; set; }
        public string overall_bearing_filter { get; set; }
        public string ordertrace_average_times { get; set; }
        public string ordertrace_resolution { get; set; }
        public string ordertrace_order { get; set; }
        public string ordertrace_trigger_slope { get; set; }
        public string time_band { get; set; }
        public string time_resoltion { get; set; }
        public string time_overlap { get; set; }
        public Nullable<int> SensorDir { get; set; }
        public Nullable<int> SensorID { get; set; }
        public Nullable<int> TemperatureID { get; set; }
        public string power_multiple { get; set; }
        public string power_band { get; set; }
        public string power_resolution { get; set; }
        public string power_band1 { get; set; }
        public string power_resolution1 { get; set; }
        public string power2_band { get; set; }
        public string power2_resolution { get; set; }
        public string power2_band1 { get; set; }
        public string power2_resolution1 { get; set; }
        public string power3_band { get; set; }
        public string power3_resolution { get; set; }
        public string power3_band1 { get; set; }
        public string power3_resolution1 { get; set; }
        public string power_window { get; set; }
        public string power_average_times { get; set; }
        public string power_overlap { get; set; }
        public Nullable<int> power_zoom { get; set; }
        public Nullable<double> power_zoom_startfeq { get; set; }
        public string cepstrum_band { get; set; }
        public string cepstrum_resolution { get; set; }
        public string cepstrum_window { get; set; }
        public string cepstrum_average_times { get; set; }
        public string cepstrum_overlap { get; set; }
        public string cepstrum_zoom { get; set; }
        public Nullable<double> cepstrum_zoom_startfeq { get; set; }
        public string demodulate_band { get; set; }
        public string demodulate_resolution { get; set; }
        public string demodulate_window { get; set; }
        public string demodulate_average_times { get; set; }
        public string demodulate_filter { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual tblAlarm tblAlarm { get; set; }
        public virtual tblMeasure_Benstone tblMeasure_Benstone { get; set; }
    }
}
