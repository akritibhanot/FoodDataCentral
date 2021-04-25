using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDataCentral.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class FoodNutrient
    {
        [Key]
        public int nutrientId { get; set; }
        public string nutrientName { get; set; }
        public string nutrientNumber { get; set; }
        public string unitName { get; set; }
        public string derivationCode { get; set; }
        public string derivationDescription { get; set; }
        public double value { get; set; }
    }

    public class Food
    {
        [Key]
        public int fdcId { get; set; }
        public string description { get; set; }
        public string lowercaseDescription { get; set; }
        public string dataType { get; set; }
        public string gtinUpc { get; set; }
        public string publishedDate { get; set; }
        public string brandOwner { get; set; }
        public string brandName { get; set; }
        public string ingredients { get; set; }
        public string marketCountry { get; set; }
        public string foodCategory { get; set; }
        public string allHighlightFields { get; set; }
        public double score { get; set; }

        [Key]
        public List<FoodNutrient> foodNutrients { get; set; }
    }

    public class Root
    {
        public List<Food> foods { get; set; }
        public string QueryInput { get; set; }
        
    }

    public class FormInput
    {
        public string QueryInput { get; set; }
    }
    
}