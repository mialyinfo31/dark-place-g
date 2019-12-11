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
            Action checkWithdrawCurrentAmount = () => new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, -100);
            Assert.Throws<ArgumentException>(checkWithdrawCurrentAmount);
        }
       
    }
}