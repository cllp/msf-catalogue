using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class AttributeClassification
    {
        public int AttributeClassID { get; set; }
        public string CharacteristicClass { get; set; }

        public int RatingValue { get; set; }
    }
}
