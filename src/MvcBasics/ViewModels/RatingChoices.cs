using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MvcBasics.ViewModels
{
    public enum RatingChoices
    {
        None,
        G,
        PG,
        [Display(Name ="PG-13")]
        PG13,
        R,
        [Display(Name = "NC-17")]
        NC17
    }
}
