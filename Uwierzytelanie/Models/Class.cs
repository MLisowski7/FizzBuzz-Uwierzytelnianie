using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Uwierzytelanie.Models;

namespace Uwierzytelanie.Models
{
    public class Class
    {   
        [Key]
        public int Id { get; set; }
        [Display(Name = "Liczba do sprawdzenia:")]
        [Required(ErrorMessage = "Pole Liczba jest obowiazkowe."), Range(1, 1000, ErrorMessage = "Wprowadzona liczba musi znajdowac sie w przedziale od 1 do 1000.")]
        public int Liczba { get; set; }
        public string Wynik { get; set; }
        public DateTime Data { get; set; }

        public string FizzBuzz(int Liczba)
        {
            if (Liczba % 3 == 0)
            { Wynik += "FIZZ"; }
            if (Liczba % 5 == 0)
            { Wynik += "BUZZ"; }
            if (Wynik == null)
            { Wynik = String.Format("Liczba: " + Liczba + " nie spełnia kryteriów Fizz/Buzz."); }
            Data = DateTime.Now;

            return Wynik;
        }
    }
}

   
   
