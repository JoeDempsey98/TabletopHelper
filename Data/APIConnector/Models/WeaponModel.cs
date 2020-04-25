using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopHelper.Data.APIConnector.Models
{
    public class WeaponModel
    {
        //change to include info gathered from weapons url
        public string Name { get; set; }
        public string URL { get; set; }
        public string WeaponCategory { get; set; }
        public string WeaponRange { get; set; }
        public string CategoryRange { get; set; }
        public CostModel Cost { get; set; }
        public DamageModel Damage { get; set; }
        public RangeModel Range { get; set; }
        public double Weight { get; set; }
        public List<PropertyModel> Properties { get; set; }
    }
}
