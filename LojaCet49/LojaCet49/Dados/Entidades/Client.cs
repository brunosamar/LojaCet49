using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCet49.Dados.Entidades
{
    public class Client
   
    {
        public int Id { get; set; }


        [Required ,Display(Name = "Name")]
        public string Name { get; set; }



        [Required, Display(Name = "Email")]
        public string Email { get; set; }



        [Required, Display(Name = "Birth")]
        public DateTime Birth { get; set; }


    


      


    }
}