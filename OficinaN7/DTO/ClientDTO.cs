using System;

namespace OficinaN7.DTO
{
    public class ClientDTO
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string CPF {get;set;}
        public string RG {get;set;}
        public DateTime BirthDate{get;set;} 
        
        public string Phone{get;set;}
        public string Email {get;set;}
        public string Rua{get;set;}
        public int Numero {get;set;}
        
        public string Complemento{get;set;}
        public string CEP {get;set;}
        public string Bairro{get;set;}
        public string Cidade{get;set;} 
        
    }
}