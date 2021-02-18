
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        //--------------------------------------------
        [Required(ErrorMessage="You must supply a Name.")]
        [MinLength(2, ErrorMessage="The title must be at least 2 characters.")]
        public string Name{get;set;}
        //--------------------------------------------
        [Required(ErrorMessage="You must supply a Location.")]
        public string Location{get;set;}
        //--------------------------------------------
        [Required(ErrorMessage="You must supply a Language.")]
        public string Language{get;set;}
        //--------------------------------------------
        [MaxLength(20, ErrorMessage="The title must be at max 20 characters.")]
        public string Comment{get;set;}
    }
}