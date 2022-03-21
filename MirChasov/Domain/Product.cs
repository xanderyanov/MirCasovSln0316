using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MirChasov
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        public ObjectId Id { get; set; }

        public string InnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string folders { get; set; }
        public object Article { get; set; }
        public int TotalCount { get; set; }
        public decimal PriceOld { get; set; }
        public string Brand { get; set; }
        public string ImgName { get; set; }
        public bool FlagNew { get; set; }
        public int HMCount { get; set; }
        public int GLCount { get; set; }
        public int LACount { get; set; }
        public int ORCount { get; set; }
        public int PACount { get; set; }
        public int TACount { get; set; }
        public string Batary10y { get; set; }
        public string Bluetooth { get; set; }
        public string Barometr { get; set; }
        public string Bracelet { get; set; }
        public string Alarm { get; set; }
        public string MuteMode { get; set; }
        public string Waterproof { get; set; }
        public string DirtResistance { get; set; }
        public string Extra { get; set; }
        public string TideIndicator { get; set; }
        public string BatteryLevelIndicator { get; set; }
        public string Compass { get; set; }
        public string CaseMaterial { get; set; }
        public string Melody { get; set; }
        public string WorldTime { get; set; }
        public string MoonDate { get; set; }
        public string Gender { get; set; }
        public string RadioSignalOfExactTime { get; set; }
        public object CaseSize { get; set; }
        [BsonIgnore]
        public string strCaseSize { get; set; }
        [BsonIgnore]
        public double dblCaseSize
        {
            get
            {
                if (CaseSize is double d) return d;
                if (CaseSize is int i) return i;
                return 0;
            }
        }
        public string PowerReserve { get; set; }
        public string ExtraLighting { get; set; }
        public string SmartphoneCommunication { get; set; }
        public object Discount { get; set; }
        public string SolarBattery { get; set; }
        public string Стекло { get; set; }
        public string CountryOFBrand { get; set; }
        public string CountryOFManufacturer { get; set; }
        public string Timer { get; set; }
        public string TimerOfFishing { get; set; }
        public string Thermometer { get; set; }
        public string MechanismType { get; set; }
        public string ImpactResistance { get; set; }
        public string MagnitResistance { get; set; }
        public string CaseForm { get; set; }
        public string SmartphoneSearchFunction { get; set; }
        public string StopwatchFunction { get; set; }
        public bool FlagSaleLeader { get; set; }
        public string ArrowStroke { get; set; }
        public string Chronograph { get; set; }
        public string ClockFace { get; set; }
        public string Pedometer { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public string Reserv1 { get; set; }

    }
}
