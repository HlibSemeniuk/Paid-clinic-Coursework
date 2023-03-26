using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Treatment
    {
        public string Recommendations { get; set; }
        public string Medicines { get; set; }
        public decimal TreatmentPrice { get; set; }
        public float SocialDiscountPercent { get; set; }

        public void ApplySocialDiscount()
        {
            TreatmentPrice = TreatmentPrice * (1 - (decimal)(SocialDiscountPercent / 100));
        }
    }
}
