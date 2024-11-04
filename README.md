# EtatHistorique
Exercice 2
## Objectifs
L'objectif de l'exercice est d'implémenter une classe EtatHistorique qui stocke les transitions d'état d'un objet.
Le système doit permettre d'afficher l'historique complet des états d'un objet, en incluant la date et la description de chaque transition.

## Implémentation de la classe EtatHistorique

Afin de bien gérer le stockage de données, nous allons utiliser dans notre classe, un object créé sous forme de JSON array qui servira à stocker l'historique des transitions. Chaque index dans le JSON sera composé de deux informations pertinentes: La date et la description de chaque transition. 
Exemple d'un objet: 


[
  {
    "Date_of_transaction": "2024-10-21T10:06:47.989456+02:00",
    "Description_of_transaction": "Initial state."
  },
  {
    "Date_of_transaction": "2024-10-21T10:08:29.9482715+02:00",
    "Description_of_transaction": "Transition 1."
  }
]

#### Fonctions
Un constructeur public EtatHistorique() qui servira à initialiser l'object JSON array (position de départ de l'objet).
Une méthode public void ChangeState(string Description_of_change) qui servira à stocker les différentes transitions.

## Implémentation du code

L'utilisateur est présenté une console qui lui indique trois choix : history, change state ou create new object. La gestion des erreurs dans le code sont géré par un Throw Execption avec un catch(e).

### History

Le code affiche l'ensemble des transisitions pour l'objet que traite l'utilisateur.

### Change 

Le code demande à l'utilisateur une description du changement d'état de l'objet puis stocke l'information via la classe EtatHistorique

### Create

L'utilisateur créé un nouvel objet et écrase les anciennes informations.

## Limite du code

Ce code présente des limites car lors de la création d'un nouvel objet, l'historique de l'objet précédent n'est pas gardé. Pour garder les anciens historiques, nous pourrions par exemple créer un objet JSON qui stockera le array fourni par la classe EtatHistorique. Ce choix d'implémentation relève de l'au-delà de l'exercice.

Exemple:

{
"OBJET 1": [{
    "Date_of_transaction": "2024-10-21T10:06:47.989456+02:00",
    "Description_of_transaction": "Initial state."
  },
  {
    "Date_of_transaction": "2024-10-21T10:08:29.9482715+02:00",
    "Description_of_transaction": "Transition 1."
  }
]}

## Author

DURU Ugochukwu
