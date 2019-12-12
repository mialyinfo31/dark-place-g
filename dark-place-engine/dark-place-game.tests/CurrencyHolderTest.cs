using System;
using Xunit;

namespace dark_place_game.tests
{

    /// Cette classe contient tout un ensemble de tests unitaires pour la classe CurrencyHolder
    public class CurrencyHolderTest
    {
        public static readonly int EXEMPLE_CAPACITE_VALIDE = 2748;
        public static readonly int EXEMPLE_CONTENANCE_INITIALE_VALIDE = 978;
        public static readonly string EXEMPLE_NOM_MONNAIE_VALIDE = "Brouzouf";

        [Fact]
        public void VraiShouldBeTrue()
        {
            var vrai = true;
            Assert.True(vrai, "Erreur, vrai vaut false. Le test est volontairement mal �crit, corrigez le.");
        }

        [Fact]
        public void CurrencyHolderCreatedWithInitialCurrentAmountOf10ShouldContain10Currency()
        {
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 10);
            var result = ch.CurrentAmount == 10;
            Assert.True(result);
        }

        [Fact]
        public void CurrencyHolderCreatedWithInitialCurrentAmountOf25ShouldContain25Currency()
        {
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 25);
            var result = ch.CurrentAmount == 25;
            Assert.True(result);
        }

        [Fact]
        public void CurrencyHolderCreatedWithInitialCurrentAmountOf0ShouldContain0Currency()
        {
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 0);
            var result = ch.CurrentAmount == 0;
            Assert.True(result);
        }

        [Fact]
        public void CreatingCurrencyHolderWithNegativeContentThrowExeption()
        {
            // Petite subtilit� : pour tester les lev�es d'exeption en c# on est oblig� d'utiliser un concept un peu exotique : les expressions lambda.
            // sans entrer dans le d�tail pour d�clarer une lambda respectez la syntaxe ci dessous, pour r�diger des tests unitaires elle devrait vous suffire.
            Action mauvaisAppel = () => new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, -10);
            Assert.Throws<ArgumentException>(mauvaisAppel);
        }

        [Fact]
        public void CreatingCurrencyHolderWithNullNameThrowExeption()
        {
            // Petite subtilit� : pour tester les lev�es d'exeption en c# on est oblig� d'utiliser un concept un peu exotique : les expression lambda.
            // sans entrer dans le d�tail pour d�clarer une lambda respectez la syntaxe ci dessous, pour r�diger des tests unitaires elle devrais vous suffire.
            Action mauvaisAppel = () => new CurrencyHolder(null, EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<ArgumentException>(mauvaisAppel);
        }

        [Fact]
        public void CreatingCurrencyHolderWithEmptyNameThrowExeption()
        {
            // Petite subtilit� : pour tester les lev�es d'exeption en c# on est oblig� d'utiliser un concept un peu exotique : les expressions lambda.
            // sans entrer dans le d�tail pour d�clarer une lambda respectez la syntaxe ci dessous, pour r�diger des tests unitaires elle devrait vous suffire.
            Action mauvaisAppel = () => new CurrencyHolder("", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<ArgumentException>(mauvaisAppel);
        }

        /** #TODO_ETAPE_4 
        ******************************/
        [Fact]
        public void BrouzoufIsAValidCurrencyName ()
        {
            // A vous d'�crire un test qui v�rife qu'on peut cr�er un CurrencyHolder contenant une monnaie dont le nom est Brouzouf
            CurrencyHolder myCurrencyHolder = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE,EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Equal(myCurrencyHolder.CurrencyName ,"Brouzouf");
        }

        [Fact]
        public void DollardIsAValidCurrencyName ()
        {
            // A vous d'�crire un test qui v�rife qu'on peut cr�er un CurrencyHolder contenant une monnaie dont le nom est Dollard
            CurrencyHolder myCurrencyHolder = new CurrencyHolder("Dollard", EXEMPLE_CAPACITE_VALIDE,EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Equal(myCurrencyHolder.CurrencyName ,"Dollard");
        }

        [Fact]
        public void TestPut10CurrencyInNonFullCurrencyHolder()
        {
            //A vous d'�crire un test qui v�rifie que si on ajoute via la methode STORE 10 currency � un sac a moit� plein, il contient maintenant la bonne quantit� de currency
            CurrencyHolder myCurrencyHolder = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,EXEMPLE_CAPACITE_VALIDE, 978 );
            myCurrencyHolder.Store(10);
            var result = myCurrencyHolder.CurrentAmount == 988;
            Assert.True(result);
        }


        [Fact]
        public void TestPut10CurrencyInNearlyFullCurrencyHolder()
        {
            // A vous d'�crire un test qui v�rifie que si on ajoute via la methode STORE 10 currency � un sac quasiement plein, une exeption NotEnoughtSpaceInCurrencyHolderExeption est lev�e.
            Action mauvaisAppel = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, 430, 425);
                ch.Store(10);
            };
            Assert.Throws<ArgumentException>(mauvaisAppel);
        }

        [Fact]
        public void CreatingCurrencyHolderWithNameShorterThan4CharacterThrowExeption()
        {
            // A vous d'�crire un test qui doit �chouer s'il est possible de cr�er un CurrencyHolder dont Le Nom De monnaie est inf�rieur a 4 lettres
            Action checkCurencyHolderName = () => new CurrencyHolder("Ar", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<ArgumentException>(checkCurencyHolderName);
        }

        [Fact]
        public void WithdrawMoreThanCurrentAmountInCurrencyHolderThrowExeption()
        {
            // A vous d'�crire un test qui v�rifie que retirer (methode withdraw) une quantit� negative de currency leve une exeption CantWithDrawNegativeCurrencyAmountExeption.
            // Astuce : dans ce cas pr�vu avant m�me de pouvoir compiler le test, vous allez �tre oblig� de cr�er la classe CantWithDrawMoreThanCurrentAmountExeption (vous pouvez la mettre dans le meme fichier que CurrencyHolder)
            Action checkWithdrawCurrentAmount = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
                ch.Withdraw(-100);
            };
            Assert.Throws<WithdrawMoreThanCurrentAmountInCurrencyHolderThrowExeption>(checkWithdrawCurrentAmount);
        }
       
        // Etape 6       
        [Fact]
        public void TestPut12CharOfName()
        {
            // Ecrivez un test pour un nom de douze caracteres
            Action checkCurencyHolderName12char = () => new CurrencyHolder("FranMalagasy", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<ArgumentException>(checkCurencyHolderName12char);
        }

        [Fact]
        public void CheckStore0()
        {
            //  Ecrivez un test pour la methode Store(0)
            Action CheckStore0 = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
                ch.Store(0);
            };
            Assert.Throws<ZeroStroreArgException>(CheckStore0);
        }

        [Fact]
        public void CheckWithdraw0()
        {
            // Ecrivez un test pour la methode Withdraw(0)
            Action CheckWithDraw0 = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
               ch.Withdraw(0);
            };
            Assert.Throws<ZeroWithdraweArgException>(CheckWithDraw0);
        }

        [Fact]
        public void CheckStartWithA()
        {
            // Un nom de currency ne doit pas commencer par la lettre a majuscule ou minuscule
            Action CheckStartWithA = () => {
                CurrencyHolder ch = new CurrencyHolder("Alibaba", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            };
            Assert.Throws<ArgumentException>(CheckStartWithA);
        }

        [Fact]
        public void CheckStartWith_a()
        {
            // Un nom de currency ne doit pas commencer par la lettre a majuscule ou minuscule
            Action CheckStartWith_a = () => {
                CurrencyHolder ch = new CurrencyHolder("adidas", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            };
            Assert.Throws<ArgumentException>(CheckStartWith_a);
        }

        [Fact]
        public void CheckCapacityValue1()
        {
            //Un CurrencyHolder ne peux avoir une capacité inférieure à 1 (1er test)
            Action CheckCapacityValue1 = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, 0,EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            };
            Assert.Throws<ArgumentException>(CheckCapacityValue1);
        }

        [Fact]
        public void CheckCapacityValue2()
        {
            //Un CurrencyHolder ne peux avoir une capacité inférieure à 1 (2 test)
            Action CheckCapacityValue2 = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, -3,EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            };
            Assert.Throws<ArgumentException>(CheckCapacityValue2);
        }

        [Fact]
        public void TestIsFull1()
        {
            //Faire 2 tests unitaires pertinents pour la methode IsEmpty (Test N°1)
            CurrencyHolder myCurrencyHolder = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,978, 978 );
            var result = myCurrencyHolder.Capacity == myCurrencyHolder.CurrentAmount;
            Assert.True(result);
        }

        [Fact]
        public void TestIsFull2()
        {
            //Faire 2 tests unitaires pertinents pour la methode IsEmpty (Test N°2)
            Action TestIsFull2 = () => {
                CurrencyHolder ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, 978,1000);
            };
            Assert.Throws<ArgumentException>(TestIsFull2);
        }

        [Fact]
        //Un CurrencyHolder est plein (IsFull) si son contenu est égal à sa capacité 
        public void TestIsFull3()
        {
            //Faire 2 tests unitaires pertinents pour la methode IsEmpty (Test N°1)
            CurrencyHolder myCurrencyHolder = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,1000,1000 );
            var result = myCurrencyHolder.Capacity == myCurrencyHolder.CurrentAmount;
            Assert.True(result);
        }

        [Fact]
        //Un CurrencyHolder est plein (IsFull) si son contenu est égal à sa capacité (4 test, y a pas de piege)
        public void TestIsFull4()
        {
            //Faire 2 tests unitaires pertinents pour la methode IsEmpty 
            CurrencyHolder myCurrencyHolder = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,500,500 );
            var result = myCurrencyHolder.Capacity == myCurrencyHolder.CurrentAmount;
            Assert.True(result);
        }


        

    }
}



/**Etape 7
Corrigez le code de CurrencyHolder jusqu'a faire passer vos tests. (en cas de doute sur vos tests
demandez à vérifier qu'ils soient valides)**/