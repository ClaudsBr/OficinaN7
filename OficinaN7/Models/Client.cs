using System;

namespace OficinaN7.Models
{
    public class Client
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string CPF {get;set;}
        public string RG {get;set;}
        public DateTime BirthDate{get;set;} 
        public string Phone{get;set;}
        public string Email {get;set;}
        
        public Address Address {get;set;}        
        public Schedule Schedule {get;set;}
        public string Role {get;set;}
        public bool Status {get;set;}


        public Client (){
            this.Role = "Cliente";
        }
    }
}