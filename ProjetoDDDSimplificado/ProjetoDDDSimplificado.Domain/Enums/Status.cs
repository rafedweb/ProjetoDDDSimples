using System;
using System.ComponentModel.DataAnnotations;


namespace ProjetoDDDSimplificado.Domain.Enums
{
    public enum Status
    {
        [Display(Name = "Ativo")]
        A = 'A',
        [Display(Name = "Inativo")]
        I = 'I',
    }
}
