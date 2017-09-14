using DomainValidation.Domain.Produto;
using System;

namespace DomainValidation.Test.TestDataBuilder
{
    public class ProdutoBuilder
    {
        public Produto CriarProduto()
        {
            return new Produto(Guid.NewGuid(), "Notebook", "Del", 20);
        }       
    }
}


//Objetivo: Separar o processo de construção de um objeto de sua representação e permitir a sua
//criação passo-a-passo.Diferentes tipos de objetos podem ser criados comimplementações distintas de
//cada passo.