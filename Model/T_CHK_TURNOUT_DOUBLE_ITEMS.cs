//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_CHK_TURNOUT_DOUBLE_ITEMS
    {
        public string PKID { get; set; }
        public string FKID { get; set; }
        public string GAUGE_SLOPE { get; set; }
        public string GAUGE_LAYUP { get; set; }
        public string GAUGE_SWITCHPOINT { get; set; }
        public string GAUGE_SWITCH { get; set; }
        public string GAUGE_SWITCHHEEL_LFT { get; set; }
        public string GAUGE_SWITCHHEEL_RHT { get; set; }
        public string GAUGE_LFT_HEAD { get; set; }
        public string GAUGE_LFT_MID { get; set; }
        public string GAUGE_LFT_TAIL { get; set; }
        public string GAUGE_RHT_HEAD { get; set; }
        public string GAUGE_RHT_MID { get; set; }
        public string GAUGE_RHT_TAIL { get; set; }
        public string GAUGE_FROG_HEAD_LFT { get; set; }
        public string GAUGE_FROG_HEAD_RHT { get; set; }
        public string GAUGE_FROG_MID_LFT { get; set; }
        public string GAUGE_FROG_MID_RHT { get; set; }
        public string GAUGE_FROG_TAIL_LFT { get; set; }
        public string GAUGE_FROG_TAIL_RHT { get; set; }
        public string GAUGE_CHECKGAGE_LFT { get; set; }
        public string GAUGE_CHECKGAGE_RHT { get; set; }
        public string GAUGE_BACKGAGE_LFT { get; set; }
        public string GAUGE_BACKGAGE_RHT { get; set; }
        public string GAUGE_OFFSET { get; set; }
        public string LEVEL_SLOPE { get; set; }
        public string LEVEL_LAYUP { get; set; }
        public string LEVEL_SWITCHPOINT { get; set; }
        public string LEVEL_SWITCH { get; set; }
        public string LEVEL_SWITCHHEEL_LFT { get; set; }
        public string LEVEL_SWITCHHEEL_RHT { get; set; }
        public string LEVEL_LFT_HEAD { get; set; }
        public string LEVEL_LFT_MID { get; set; }
        public string LEVEL_LFT_TAIL { get; set; }
        public string LEVEL_RHT_HEAD { get; set; }
        public string LEVEL_RHT_MID { get; set; }
        public string LEVEL_RHT_TAIL { get; set; }
        public string LEVEL_FROG_HEAD_LFT { get; set; }
        public string LEVEL_FROG_HEAD_RHT { get; set; }
        public string LEVEL_FROG_MID_LFT { get; set; }
        public string LEVEL_FROG_MID_RHT { get; set; }
        public string LEVEL_FROG_TAIL_LFT { get; set; }
        public string LEVEL_FROG_TAIL_RHT { get; set; }
        public string LEVEL_CHECKGAGE_LFT { get; set; }
        public string LEVEL_CHECKGAGE_RHT { get; set; }
        public string LEVEL_BACKGAGE_LFT { get; set; }
        public string LEVEL_BACKGAGE_RHT { get; set; }
        public string TWIST_SLOPE { get; set; }
        public string TWIST_LAYUP { get; set; }
        public string TWIST_SWITCHPOINT { get; set; }
        public string TWIST_SWITCH { get; set; }
        public string TWIST_SWITCHHEEL_LFT { get; set; }
        public string TWIST_SWITCHHEEL_RHT { get; set; }
        public string TWIST_LFT_HEAD { get; set; }
        public string TWIST_LFT_MID { get; set; }
        public string TWIST_LFT_TAIL { get; set; }
        public string TWIST_RHT_HEAD { get; set; }
        public string TWIST_RHT_MID { get; set; }
        public string TWIST_RHT_TAIL { get; set; }
        public string TWIST_FROG_HEAD_LFT { get; set; }
        public string TWIST_FROG_HEAD_RHT { get; set; }
        public string TWIST_FROG_MID_LFT { get; set; }
        public string TWIST_FROG_MID_RHT { get; set; }
        public string TWIST_FROG_TAIL_LFT { get; set; }
        public string TWIST_FROG_TAIL_RHT { get; set; }
        public string TWIST_CHECKGAGE_LFT { get; set; }
        public string TWIST_CHECKGAGE_RHT { get; set; }
        public string TWIST_BACKGAGE_LFT { get; set; }
        public string TWIST_BACKGAGE_RHT { get; set; }
        public string RECORD { get; set; }
        public string CRITICAL_ACTIVITY { get; set; }
        public Nullable<System.DateTime> CHK_TM { get; set; }
        public Nullable<decimal> LNG { get; set; }
        public Nullable<decimal> LAT { get; set; }
        public Nullable<decimal> MARS_LNG { get; set; }
        public Nullable<decimal> MARS_LAT { get; set; }
        public Nullable<decimal> BAIDU_LNG { get; set; }
        public Nullable<decimal> BAIDU_LAT { get; set; }
        public Nullable<System.DateTime> T_GPS_TM { get; set; }
        public string RECHECK_FLAG { get; set; }
    
        public virtual T_CHK_TURNOUT T_CHK_TURNOUT { get; set; }
    }
}
