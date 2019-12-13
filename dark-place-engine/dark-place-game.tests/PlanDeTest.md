# - - - - - - - - - - - - - - - - - - -
# PLAN DE TEST D ACCEPTATION  : NB: Les points de vies sont aléatoires ..
# - - - - - - - - - - - - - - - - - - -
Round 1 :
    Démarrer le jeux :
    Pour un point de vie allant de 20 et 40 :
    Vérifier que point de vie de P1 est compris entre 20 et 40;
    Vérifier que point de vie de P2 est compris entre 20 et 40;

    Configurer le jeux :
        P1 Guerrier , à 35/35 de point de vie est pret. 
            Il est armée de sabre 
            Le sabre vaut 5 points de dégats
        P2 Orc , à 40/40 de point de vie est pret. 
            Il est armée de marteau 
            Le marteau vaut 3 points de dégats

    Lancer la partie :
        P1 attaque P2:
            Tanque que P2 n'esquive pas l'attaque et qu'il lui reste des points de vie :
            Point de vie de P2 diminue de 5 points par attaque reçue.
            Si point de vie P2 atteind 0/40 , P1 gagne et P2 perd

        P2 attaque P1
            Après une attaque esquivée P2 attaque P1
            Tanque que P1 n'esquive pas l'attaque et qu'il lui reste des points de vie :
            Point de vie de P1 diminue de 3 points par attaque reçue.
            Si point de vie P1 atteind 0/35 , P2 gagne et P1 perd


# Différents critères pour le déroulement du jeu:
Au démarrage s'assurer que : 
 => la partie est initialisée à 1
 => deux avatars sont disponibles : Orc et Guerrier
 => deux joueurs non identiques sont créés 
 => les points de vie des 2 joueurs sont initialisés et compris entre 20 et 40 ex : 20/20
 => chaque joueur a une méthode d'attaque opérationnelle
 => chaque méthode d'attaque peut soit comporter une arme soit être une attaque corporelle
 => 4 armes sont disponibles pour équiper les joueurs.
 => chaque arme utilisée comporte un nombre de point de dégats compris entre 1 et 6

# Les obstacles à l'automatisation de ces tests (ils peuvent être contournés).
Les obstacles à l'automatisation de ces tests sont le caractère aléatoire des points de vies.
Il faudrait avoir la possibilité de les initialiser.

# Décriver le concepts des Mocks, des Fakes et de stubs.
Mocks
     sont des objets qui enregistrent les appels qu'ils reçoivent.
     Un exemple peut être une fonctionnalité qui appelle le service d'envoi de courriels.
    Nous ne voulons pas envoyer de courriels chaque fois que nous faisons un test. De plus, il n'est pas facile de vérifier dans les tests qu'un bon email a été envoyé. La seule chose que nous pouvons faire est de vérifier les sorties de la fonctionnalité qui est exercée dans notre test. Dans d'autres mondes, vérifiez que le service d'envoi d'e-mail a été appelé.

Fakes
    ce sont des objets qui ont des implémentations fonctionnelles, mais pas les mêmes que les objets de production. Habituellement, ils prennent quelques raccourcis et ont une version simplifiée du code de production.

Stubs
    est un objet qui contient des données prédéfinies et les utilise pour répondre aux appels pendant les tests. Il est utilisé lorsque nous ne pouvons pas ou ne voulons pas impliquer des objets qui répondraient avec des données réelles ou qui auraient des effets secondaires indésirables.

# la différence entre un test d'acceptation et un test unitaire:
La différence est que le test d'accepation vise à vérifier les critères minimum pour garantir 
le fonctionnement de l'ensemble du système tandis que le test unitaire va tester une méthode précise sur un objet précis.

