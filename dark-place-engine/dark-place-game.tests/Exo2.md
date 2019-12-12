# TP Dark-Place Engine Partie 2
# INSTRUCTIONS: ne faire que la rédaction du document test d'acceptation, sans implémentation de code
# ie: imaginer des scénarios
# Eg de plan de test : TEST 1
# ----- allumer calculette => appuyer sur 2 => vérifier que 2 s'affiche => appuyer sur "+"
# ----- appuyer sur 5 => vérifier que 5 s'affiche => appuyer sur "=" => Résultat vaut 7 et 7 s'affiche


Vous allez réaliser les test pour un mini jeu en ligne de commande. 
il s'agit d'un jeu à tour de roles entre deux joueurs.

au debut du jeu deux personnages sont créés Guerrier et orc

au debut du round il affiche :

p1 le guerrier est pret !
p2 l'orc est pret !

a chaque round, une ligne de type 
P1 guerrier 10/10 est pret.
tapez un pour attaquer.
Guerrier frappe avec son épée pour 5 points de degats.
p2 Orc 5/10 est pret.
tapez un pour attaquer.
Orc tape avec sa hache pour 3 points de degats.
P1 guerrier 7/10 est pret.
tapez un pour attaquer.
Guerrier frappe avec son épée pour 7 points de degats.
Orc meurt.
P1 Gagne !

les attaquent infligent entre 1 et 6 degats.
Les personnages ont entre 20 et 40 points de vie.

Proposer un plan de tests d'acceptation pour le jeu.

Définissez différents critères pour le déroulement du jeu.

Identifiez les obstacles à l'automatisation de ces tests (ils peuvent être contournés).

Décriver le concepts des Mocks, des Fakes et de stubs.

Définissez la différence entre un test d'acceptation et un test unitaire.
