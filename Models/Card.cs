using System;
using System.ComponentModel.DataAnnotations;

namespace vaivoaCard.Models
{
    public class Card
    {

        //Campo identificador único para cada cartão cadastrado
        [Key]
        public int CardId {get;set;}

        //Campo Email com validação mínima para 6 caracteres - Ex.: a@b.uk
        [MinLength(6, ErrorMessage = "Este campo deve conter no mínimo 6 caracteres")]
        public string CardEmail {get;set;}

        //Função Random para gerar números aleatórios
        //Usado para gerar numero do cartão e codigo de segurança
        static int setNumCard(int inic, int fim){
            Random gerador = new Random();
            int card = gerador.Next(inic, fim);
            return card;
        }

        // Gerar número fictício do cartão com 16 digitos divido em 4 blocos
        public string card = setNumCard(1000, 9999).ToString() 
                    +"-"+ setNumCard(1000, 9999).ToString() 
                    +"-"+ setNumCard(1000, 9999).ToString() 
                    +"-"+ setNumCard(1000, 9999).ToString();
        public string CardNCard 
        {
            get {return card;}
            set {card = value;}
        }

        //Gerar código de segurança fictício com 3 díigitos
        private int seg = setNumCard(100, 999);
        public int CardCSeg 
        {
            get {return seg;}
            set {seg = value;}
        }

        //Validade do cartão com vencimento para 1 ano a partir da data de criação
        private DateTime dataCadastro = DateTime.Today;
        public DateTime CardValid
        {
            get { return dataCadastro.AddDays(360); }
            set { dataCadastro = value; }
        }
    }
}