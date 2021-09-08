﻿using MyCity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyCity.Resources.Enums;

namespace MyCity.Services
{
    public class EstablishmentServices
    {
        public List<Establishment> GetEstablishments()
        {
            var ListEstablishments = new List<Establishment>()
            {
                new Establishment()
                {
                    IdEstablishment = 1,
                    TypeEstablishment = EstablishmentType.StoreType,
                    NameEstablishment = "Renner",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/122012/renner_0.png?itok=VvGKSsDe",
                    DescriptionEstablishment = "A Lojas Renner S.A. é uma rede de lojas de departamento brasileira.",
                    AddressEstablishment = "2 Andar - Loja 10/11/12/13/14 - Entrada Norte",
                    PhoneEstablishment = "(61) 3333-3333",
                },
                new Establishment()
                {
                    IdEstablishment = 2,
                    TypeEstablishment = EstablishmentType.StoreType,
                    NameEstablishment = "Samsung",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052012/samsung.png?itok=Mq0egkoi",
                    DescriptionEstablishment = "Agora, você tem mais uma opção para experimentar e conhecer os produtos Samsung, antes de tomar a sua decisão de compra. Isso porque, nas Lojas Samsung, você pode manusear celulares, tablets, câmeras, smartPhoneEstablishments e notebooks livremente, e ainda conta com consultoria e atendimento de vendedores especializados. A experiência de compra de equipamentos tecnológicos deixa de ser impessoal e ganha um caráter mais assertivo e direcionado ao seu verdadeiro desejo.",
                    AddressEstablishment = "2 Andar - Loja 01/02 - Entrada Norte",
                    PhoneEstablishment = "(61) 3475-2650",
                },
                new Establishment()
                {
                    IdEstablishment = 3,
                    TypeEstablishment = EstablishmentType.StoreType,
                    NameEstablishment = "Chilli Beans",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052016/logo_chilli_beans_1c.png?itok=w_B1Ywks",
                    DescriptionEstablishment = "A maior rede brasileira de óculos escuros e acessórios”. Essa definição resume a Chilli Beans: provocativa, ardente e envolvente. É a marca da pimenta. Uma marca que, toda semana, lança novos óculos, novos relógios e novas possibilIdEstablishmentades. Ou seja, novas formas de compor seu visual. Com mais de 580 pontos de venda exclusivos no Brasil, Estados UnIdEstablishmentos, Portugal, Peru, Colômbia e Kuwait, a Chilli Beans é uma marca diversificada, com uma linha de produtos que inclui, além dos óculos escuros e relógios, armações de óculos de grau e lentes em pontos de vendas exclusivos. Além disso, a marca está por trás de um mundo de ações de patrocínio de festas, shows, esportes e ações sociais",
                    AddressEstablishment = "2 Andar - Loja 03 - Entrada Norte",
                    PhoneEstablishment = "(61) 3475-2744",
                },
                new Establishment()
                {
                    IdEstablishment = 4,
                    TypeEstablishment = EstablishmentType.StoreType,
                    NameEstablishment = "POLYÉLLE",
                    LogoEstablishment = "https://th.bing.com/th/IdEstablishment/OIP.Iyszwlgme5PIaZiSCzshiwAAAA?pIdEstablishment=Api&rs=1",
                    DescriptionEstablishment = "Em 1984, iniciou-se a trajetória da Polyelle no segmento de calçados. Depois de um tempo, esse segmento foi ampliado também para bolsas, cintos, carteiras e artigos esportivos e hoje, conta com mais de duzentos fornecedores de marcas nacionais e internacionais. A empresa foi estruturada para inovar por meio de pesquisas de consumIdEstablishmentores e concorrentes, sempre preocupada em oferecer a melhor seleção das tendências mundiais a preços acessíveis.",
                    AddressEstablishment = "2 Andar - Loja 04/05/06 - Entrada Norte",
                    PhoneEstablishment = "(61) 3313-7843",
                },
                new Establishment()
                {
                    IdEstablishment = 5,
                    TypeEstablishment = EstablishmentType.StoreType,
                    NameEstablishment = "LOJAS AMERICANAS",
                    LogoEstablishment = "https://static.pelando.com.br/live/merchants/avatar_web_square_94_2x/avatar/275_3.jpg",
                    DescriptionEstablishment = "Aqui você encontra de tudo um pouco: De eletrodomésticos a artigos de vestuário feminino, masculino e infantil.",
                    AddressEstablishment = "2 Andar - Loja 07/08/09 - Entrada Norte",
                    PhoneEstablishment = "-",
                },
                new Establishment()
                {
                    IdEstablishment = 6,
                    TypeEstablishment = EstablishmentType.StoreType,
                    NameEstablishment = "HERING STORE",
                    LogoEstablishment = "https://mundodasdicas.com.br/wp-content/uploads/2021/06/hering-loja-virtual.jpg",
                    DescriptionEstablishment = "A Hering Store é uma loja de roupas femininas e masculinas que atende ao público adulto.",
                    AddressEstablishment = "2 Andar - Loja 10/11 - Entrada Norte",
                    PhoneEstablishment = "(61) 3973-3352",
                },
                new Establishment()
                {
                    IdEstablishment = 7,
                    TypeEstablishment = EstablishmentType.StoreType,                   
                    NameEstablishment = "O BOTICÁRIO",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/032013/boticario_0.jpg?itok=bEHTxK_c",
                    DescriptionEstablishment = "O Boticário é uma loja de cosméticos em geral que oferece produtos para pele, cabelo, esmaltes, maquiagem e perfumaria.",
                    AddressEstablishment = "1 Andar - Loja 20/21 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2646",
                },
                new Establishment()
                {
                    IdEstablishment = 8,
                    TypeEstablishment = EstablishmentType.StoreType,                    
                    NameEstablishment = "C&A",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/0004/0708/brand.gif?itok=prfpF4FG",
                    DescriptionEstablishment = "Compre Roupas Femininas, Masculinas e Infantis, Eletrônicos, Cosméticos e Perfumaria na Loja Online da C&A. Entrega RápIdEstablishmenta, Troca Fácil e muito + Vem ver! C&A Loja Online - Moda, Roupas, Celulares e …",
                    AddressEstablishment = "1 Andar - Loja 22/23 - Entrada Sul",
                    PhoneEstablishment = "(61) 2191-8845",
                },
                new Establishment()
                {
                    IdEstablishment = 9,
                    TypeEstablishment = EstablishmentType.StoreType,              
                    NameEstablishment = "OI",
                    LogoEstablishment = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Logo_OI.svg/100px-Logo_OI.svg.png",
                    DescriptionEstablishment = "A Oi é uma loja que representa a operadora de telefonia de mesmo nome. A Loja Oi presta assistência, auxilia o consumIdEstablishmentor a respeito de novos planos e vende celulares/smartPhoneEstablishments.",
                    AddressEstablishment = "1 Andar - Loja 22/23 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2689",
                },
                new Establishment()
                {
                    IdEstablishment = 10,
                    TypeEstablishment = EstablishmentType.StoreType,           
                    NameEstablishment = "CLARO",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/092011/claro_2_1.jpg?itok=EYXF3uUg",
                    DescriptionEstablishment = "A Claro é uma loja de telefonia que vende aparelhos e presta assistência a clientes da operadora de mesmo nome.",
                    AddressEstablishment = "1 Andar - Loja 24/25 - Entrada Sul",
                    PhoneEstablishment = "**",
                },
                new Establishment()
                {
                    IdEstablishment = 11,
                    TypeEstablishment = EstablishmentType.StoreType,     
                    NameEstablishment = "CVC VIAGENS",
                    LogoEstablishment = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/032017/untitled-2_42.png?itok=a0FktvOz",
                    DescriptionEstablishment = "Compre suas passagens aéreas com pacotes completos na CVC do JK Shopping.  Sempre com os melhores preços e promoções para você viajar o mundo todo.",
                    AddressEstablishment = "1 Andar - Loja 26/27 - Entrada Sul",
                    PhoneEstablishment = "**",
                },
                new Establishment()
                {
                    IdEstablishment = 12,
                    TypeEstablishment = EstablishmentType.StoreType,   
                    NameEstablishment = "POLISHOP",
                    LogoEstablishment = "https://botw-pd.s3.amazonaws.com/styles/logo-thumbnail/s3/0022/2333/brand.gif?itok=m1Wcro5R",
                    DescriptionEstablishment = "Na Polishop você encontra Soluções Inteligentes para sua Casa, Saúde e Beleza. Produtos exclusivos e novIdEstablishmentades que facilitam sua vIdEstablishmenta.",
                    AddressEstablishment = "1 Andar - Loja 28/29 - Entrada Sul",
                    PhoneEstablishment = "**",
                },
                new Establishment()
                {
                    IdEstablishment = 13,
                    TypeEstablishment = EstablishmentType.StoreType,      
                    NameEstablishment = "FUJIOKA",
                    LogoEstablishment = "https://vagasabertas.org/wp-content/uploads/2012/03/Vagas-de-Emprego-na-empresa-Fujioka.jpg",
                    DescriptionEstablishment = "O Fujioka é uma loja de eletrônicos e informática que oferece, ainda, produtos de áudio, vídeo, telefonia e serviços fotográficos.",
                    AddressEstablishment = "1 Andar - Loja 30/31 - Entrada Sul",
                    PhoneEstablishment = "(61) 3471-8600",
                },
                new Establishment()
                {
                    IdEstablishment = 14,
                    TypeEstablishment = EstablishmentType.StoreType,          
                    NameEstablishment = "QUEM DISSE, BERENICE?",
                    LogoEstablishment = "https://th.bing.com/th/IdEstablishment/OIP._7UmPQ-CwGjuohFLU4qm6AAAAA?pIdEstablishment=Api&rs=1",
                    DescriptionEstablishment = "A Quem disse, Berenice? é uma loja de maquiagens e cosméticos que tem uma proposta jovial e alegre que veio para quebrar padrões.",
                    AddressEstablishment = "1 Andar - Loja 34 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2419",
                },
                new Establishment()
                {
                    IdEstablishment = 15,
                    TypeEstablishment = EstablishmentType.StoreType,       
                    NameEstablishment = "PARIS JÓIAS",
                    LogoEstablishment = "https://scontent.fbsb16-1.fna.fbcdn.net/v/t1.0-1/cp0/p40x40/32530741_1756089587820698_2942969221090377728_o.png?_nc_cat=103&ccb=2&_nc_sIdEstablishment=dbb9e7&_nc_ohc=-6Rj2o-DEEYAX8klDV3&_nc_ht=scontent.fbsb16-1.fna&_nc_tp=30&oh=8e62d997241361eca89cd00ee4cff32d&oe=6008EA19",
                    DescriptionEstablishment = "A Paris Jóias é uma loja de jóias e semi jóias que atrai pelo glamour e design das peças.",
                    AddressEstablishment = "1 Andar - Loja 35 - Entrada Sul",
                    PhoneEstablishment = "**",
                },
                new Establishment()
                {
                    IdEstablishment = 16,
                    TypeEstablishment = EstablishmentType.StoreType,           
                    NameEstablishment = "COOL CAT",
                    LogoEstablishment = "https://scontent.fbsb16-1.fna.fbcdn.net/v/t1.0-9/73057735_2792663367412106_2803336995324035072_n.png?_nc_cat=109&ccb=2&_nc_sIdEstablishment=09cbfe&_nc_ohc=eWlalGifPSUAX-fNdXh&_nc_ht=scontent.fbsb16-1.fna&oh=6bb8b45e83b5d8b4c4ac866e4f4461b1&oe=6008A509",
                    DescriptionEstablishment = "A Cool Cat é uma loja de roupas casuais para homens e mulheres, com foco na moda surfware e streetware.",
                    AddressEstablishment = "1 Andar - Loja 36 - Entrada Sul",
                    PhoneEstablishment = "61 3491-2407",
                },
                new Establishment()
                {
                    IdEstablishment = 17,
                    TypeEstablishment = EstablishmentType.StoreType,           
                    NameEstablishment = "TNG",
                    LogoEstablishment = "https://bazarpop.files.wordpress.com/2008/06/logo_tng.gif",
                    DescriptionEstablishment = "Com DNA jovem a TNG lança tendências com estilo e autenticIdEstablishmentade. Conheça as coleções masculinas e femininas. Aproveite o melhor da moda. Confira!",
                    AddressEstablishment = "1 Andar - Loja 37 - Entrada Sul",
                    PhoneEstablishment = "(11) 4689-7375",
                },
                new Establishment()
                {
                    IdEstablishment = 18,
                    TypeEstablishment = EstablishmentType.StoreType,     
                    NameEstablishment = "PITICAS",
                    LogoEstablishment = "https://th.bing.com/th/IdEstablishment/OIP.8Apu8unhr4A8enO5vgxF6gHaHa?pIdEstablishment=Api&rs=1",
                    DescriptionEstablishment = "Piticas: Ano de Fundação: 2010: Inicio do Franchising: 2011: UnIdEstablishmentades Franqueadas: 340: Comunicado Franchise Store: Os dados e conteúdos informados foram fornecIdEstablishmentos exclusivamente pela Franqueadora. ",
                    AddressEstablishment = "1 Andar - Loja 38 - Entrada Sul",
                    PhoneEstablishment = "(61) 3053-8009",
                },
                new Establishment()
                {
                    IdEstablishment = 19,
                    TypeEstablishment = EstablishmentType.StoreType,       
                    NameEstablishment = "BIO MUNDO",
                    LogoEstablishment = "https://www.lojabiomundo.com.br/FILES/_ARQUIVOS/LOGO/logo.png",
                    DescriptionEstablishment = "Bio Mundo é a loja de produtos naturais que vem promovendo saúde e bem estar à vIdEstablishmenta das pessoas desde 2015, quando suas portas foram abertas pela primeira vez, em Brasília.",
                    AddressEstablishment = "1 Andar - Loja 39 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2789",
                },
                new Establishment()
                {
                    IdEstablishment = 20,
                    TypeEstablishment = EstablishmentType.StoreType,    
                    NameEstablishment = "ZINZANE",
                    LogoEstablishment = "https://www.cupomvalIdEstablishmento.com.br/logo/www.zinzane.com.br.png.pagespeed.ce.cTfK8gTDeL.png",
                    DescriptionEstablishment = "Zinzane é uma marca de moda feminina que nasceu em 2002, no Rio de Janeiro, na charmosa Babilônia Feira Hype. Atualmente, possuímos 113 lojas físicas próprias e estamos presentes em 19 estados brasileiros, além da forte atuação no canal digital, através da nossa loja online, com o objetivo de levar as últimas tendências para todo o Brasil. Lançamos semanalmente novos produtos exclusivos e nossa missão é encantar o cliente, ofertando o melhor produto, com o melhor custo benefício. Nossas estampas exclusivas são o carro-chefe da marca, vistas em produtos de variados estilos e modelagens. Aqui, você encontra o look perfeito para estar no seu guarda-roupa.",
                    AddressEstablishment = "1 Andar - Loja 39 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2789",
                },

                new Establishment()
                {
                    IdEstablishment = 21,
                    TypeEstablishment = EstablishmentType.StoreType,           
                    NameEstablishment = "OUTBACK",
                    LogoEstablishment = "https://botw-pd.s3.amazonaws.com/styles/logo-thumbnail/s3/102014/logo_outback.png?itok=dKkkYi4q",
                    DescriptionEstablishment = "Outback Steakhouse",
                    AddressEstablishment = "3 Andar - Loja 01/02/03/04 - Entrada Sul",
                    PhoneEstablishment = "(61) 3550-1874",
                },
                new Establishment()
                {
                    IdEstablishment = 22,
                    TypeEstablishment = EstablishmentType.StoreType,  
                    NameEstablishment = "GIRAFFAS",
                    LogoEstablishment = "https://th.bing.com/th/IdEstablishment/OIP.rkuaDq-syjT-EZdhuQ6GfgHaGU?pIdEstablishment=Api&rs=1",
                    DescriptionEstablishment = "O Giraffas é uma rede de restaurantes de culinária brasileira que serve seus pratos de forma saborosa e criativa.",
                    AddressEstablishment = "3 Andar - Loja 05/06/07 - Entrada Sul",
                    PhoneEstablishment = "(61) 3550-1874",
                },
                new Establishment()
                {
                    IdEstablishment = 23,
                    TypeEstablishment = EstablishmentType.StoreType,    
                    NameEstablishment = "MC DONALD’S",
                    LogoEstablishment = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/McDonald%27s_SVG_logo.svg/120px-McDonald%27s_SVG_logo.svg.png",
                    DescriptionEstablishment = "Quiosque de sorvetes e milk shakes do Mc Donald’s.",
                    AddressEstablishment = "3 Andar - Loja 08/09/10/11 - Entrada Sul",
                    PhoneEstablishment = "(61) 3550-1874",
                },
                new Establishment()
                {
                    IdEstablishment = 24,
                    TypeEstablishment = EstablishmentType.StoreType,         
                    NameEstablishment = "BOB’S",
                    LogoEstablishment = "https://cdn4.bobsfa.com.br/bobs/images/logo_bobs.png",
                    DescriptionEstablishment = "O Bob’s é uma rede de restaurantes fast-food que busca atender às expectativas do consumIdEstablishmentor através de um produto de qualIdEstablishmentade e uma equipe sempre motivada.",
                    AddressEstablishment = "3 Andar - Loja 13/14 - Entrada Sul",
                    PhoneEstablishment = "(61) 3491-1031",
                },
                new Establishment()
                {
                    IdEstablishment = 25,
                    TypeEstablishment = EstablishmentType.StoreType,      
                    NameEstablishment = "BURGER KING",
                    LogoEstablishment = "https://farm5.staticflickr.com/4045/4704236172_e6e6eebf39_q_d.jpg",
                    DescriptionEstablishment = "O BURGER KING® é a segunda maior rede de hambúrgueres do mundo. Lar original do WHOPPER®, um dos mais pedIdEstablishmentos da franquia.",
                    AddressEstablishment = "3 Andar - Loja 15/16 - Entrada Sul",
                    PhoneEstablishment = "**",
                },
                new Establishment()
                {
                    IdEstablishment = 26,
                    TypeEstablishment = EstablishmentType.StoreType,       
                    NameEstablishment = "CHOCOLATES BRASIL CACAU",
                    LogoEstablishment = "https://3.bp.blogspot.com/-sXotIRuVUp4/T2tI3C89l8I/AAAAAAAAAHE/qcowULZfBWs/s950/Logo%2Bblog.jpg",
                    DescriptionEstablishment = "A Brasil Cacau é uma bomboniére que oferece produtos diversificados para agradar a todos os tipos de amantes do chocolate.",
                    AddressEstablishment = "3 Andar - Loja 17/18 - Entrada Sul",
                    PhoneEstablishment = "(61) 3491-2255",
                },
                new Establishment()
                {
                    IdEstablishment = 27,
                    TypeEstablishment = EstablishmentType.StoreType,          
                    NameEstablishment = "CACAU SHOW",
                    LogoEstablishment = "https://th.bing.com/th/IdEstablishment/OIP.bu6ExCsGqSc1mE3-76gLWAAAAA?pIdEstablishment=Api&rs=1",
                    DescriptionEstablishment = "A Cacau Show é uma loja de chocolates conhecIdEstablishmenta nacionalmente que oferece produtos variados da área de bomboniére.",
                    AddressEstablishment = "3 Andar - Loja 19 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2779",
                },
                new Establishment()
                {
                    IdEstablishment = 28,
                    TypeEstablishment = EstablishmentType.StoreType,    
                    NameEstablishment = "DIVINO FOGÃO",
                    LogoEstablishment = "https://th.bing.com/th/IdEstablishment/OIP.CovkvJKc9p-mUagzdJjYVgAAAA?pIdEstablishment=Api&rs=1",
                    DescriptionEstablishment = "O Divino Fogão é um restaurante que oferece comIdEstablishmenta típica da fazenda num cardápio saboroso e variado.",
                    AddressEstablishment = "3 Andar - Loja 20 - Entrada Sul",
                    PhoneEstablishment = "(61) 3491-1124",
                },
                new Establishment()
                {
                    IdEstablishment = 29,
                    TypeEstablishment = EstablishmentType.StoreType,    
                    NameEstablishment = "FRANGO NO POTE",
                    LogoEstablishment = "https://www.feiradefranquias.com.br/wp-content/uploads/2017/02/Frango-no-Pote.png",
                    DescriptionEstablishment = "O Frango no Pote é uma rede que não para de crescer. Oferece porções de frango, refrigerantes e lanches.",
                    AddressEstablishment = "3 Andar - Loja 21 - Entrada Sul",
                    PhoneEstablishment = "(61) 3475-2786",
                },
                new Establishment()
                {
                    IdEstablishment = 30,
                    TypeEstablishment = EstablishmentType.StoreType,       
                    NameEstablishment = "SPOLETO",
                    LogoEstablishment = "https://upload.wikimedia.org/wikipedia/pt/thumb/8/80/Spoleto_logo.png/120px-Spoleto_logo.png",
                    DescriptionEstablishment = "O Spoleto é um restaurante italiano que visa valorizar as relações, manter a qualIdEstablishmentade nos produtos e serviços e aprimorar e inovar cada vez mais com foco nas pessoas e respeito à concorrência.",
                    AddressEstablishment = "3 Andar - Loja 22 - Entrada Sul",
                    PhoneEstablishment = "(61) 3491-1031",
                },
            };
            return ListEstablishments;
        }
    }
}
